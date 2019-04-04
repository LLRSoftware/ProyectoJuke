using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using empleados.conexion;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace empleados.Controller

{
    
    class ModificarUser
    {
        conexiondb conexion = new conexiondb();

        public void llenarUsuario(ComboBox cb) {
            conexion.abrir();
            try
            {
                String sql = "Select Nombre from usuario order by Nombre asc";
                SqlCommand leer = new SqlCommand(sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    cb.Items.Add(conn["Nombre"].ToString());
                }
                cb.SelectedIndex = 0;
            }catch(Exception ex)
            {
                MessageBox.Show("Error al conectar con la BD "+ ex);
            }

            conexion.cerrar();
        }

        public void llenarPerfil(ComboBox cb)
        {
            conexion.abrir();
            try
            {
                String sql = "Select Nombre from perfil ";
                SqlCommand leer = new SqlCommand(sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read())
                {
                    cb.Items.Add(conn["Nombre"].ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la BD " + ex);
            }

            conexion.cerrar();
        }

        public String PassAnt(String Usuario) {
            String Pass = "";
            conexion.abrir();
            try {
                String sql = "select Contraseña from usuario where Nombre = '"+ Usuario +"'";
                SqlCommand leer = new SqlCommand(sql, conexion.conectar);
                SqlDataReader conn = leer.ExecuteReader();
                while (conn.Read()) {
                    Pass = conn["Contraseña"].ToString();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error al conectar con la BD "+ ex);
            }
            conexion.cerrar();
            return Pass;
        }


        public Boolean validar(String Pass)
        {
            int contaMay = 0;
            int contaMin = 0;
            int num = 0;
            int cantidad = Pass.Length;
            char[] cadena = Pass.ToCharArray();
            String[] sms = new String[cantidad];
            String[] AbcMay = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ","O", "P", "Q", "R", "S","T","U","V","W","X","Y","Z" };
            String[] AbcMin = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ","o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int[] numeros = { 1, 2, 3,4 , 5, 6, 7, 8, 9, 0};
            
            int val1 = 0;

            for (int i=0; i< cantidad; i++) {
                sms[i] = cadena[i].ToString();
            }
          

            for (int j = 0; j < cantidad; j++)
            {
                
                for (int x=0; x < 27; x++)
                {
                   
                    if (sms[j].Equals(AbcMay[x]))
                    {
                        contaMay++;
                        break;
                    }
                    else
                    {
                        
                        if (sms[j].Equals(AbcMin[x]))
                        {
                            contaMin++;
                            break;
                        }
                        else
                        {

                            if (x < 10)
                            {
                                try {
                                    val1 = int.Parse(sms[j]);
                                }
                                catch (Exception ex) {

                                }
                                if (val1 == numeros[x])
                                {
                                    num++;
                                    break;
                                }
                            }
                        }
                    }
                }
               
            }

            if (contaMay > 0 && contaMin > 0 && num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public void estatus(ComboBox cb) {
            cb.Items.Add("Activo");
            cb.Items.Add("Inactivo");
        }


        public String modificar(String usuario, String pass, String perfil, String estatus)
        {
            String mensaje = "";
            int per = 0;
            String est = "";


            conexion.abrir();
            if (perfil.Equals(""))
            {
                try
                {
                    String sql = "select Id_perfil from usuario where Nombre ='" + usuario + "'";
                    SqlCommand leer = new SqlCommand(sql, conexion.conectar);
                    SqlDataReader conn = leer.ExecuteReader();
                    while (conn.Read())
                    {
                        per = conn.GetInt16(0);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la bd  " + ex);
                }
                
            }
            else {
                try
                {
                    String sql = "select Id_Perfil from perfil where Nombre ='" + perfil + "'";
                    SqlCommand leer = new SqlCommand(sql, conexion.conectar);
                    SqlDataReader conn = leer.ExecuteReader();
                    while (conn.Read())
                    {
                        per = conn.GetInt16(0);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la bd  " + ex);
                }
            }

            if (estatus.Equals(""))
            {
                try
                {
                    String sql = "select Estatus from usuario where Nombre ='"+usuario+"', ";
                    SqlCommand leer = new SqlCommand(sql, conexion.conectar);
                    SqlDataReader conn = leer.ExecuteReader();
                    while (conn.Read())
                    {
                        est = conn.GetString(0).ToString();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar en la BD" + ex);
                }
            }
            else {
                est = estatus;
            }
           

            try
            {
                String sql = "Update usuario set Contraseña='"+pass+"', Estatus ='"+est+"',Id_Perfil="+per+"where Nombre='"+usuario+"'";
                SqlCommand update = new SqlCommand(sql,conexion.conectar);
                update.ExecuteNonQuery();
                mensaje = "1 Los datos han sido modificados satisfactoriamente!!!";

            }catch(Exception ex)
            {
                mensaje = "2 Error al conectar con la BD" + ex;
            }
            conexion.cerrar();


            return mensaje;


        }


    }
}
