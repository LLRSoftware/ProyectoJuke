﻿// Vista Empleados
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using emple.Model;
using Datos_personales.Model;
using WindowsFormsApp1;
using empleados.Controller;

namespace empleados 
{
    public partial class empleados : Form
    {
        
        Emple objeto = new Emple(); // Variable "Emple" de la clase Model 
        datosPersonal datospersonal = new datosPersonal(1);
        Datos_Personales dts = new Datos_Personales(); //Variable "Datos_Personales"  de la clase Model
       
        empleado inser = new empleado();


        public empleados() // Inicializa la vista empleados 
        {
            InitializeComponent();
        }


        public void insertar()
        {
            string mensaje = "";
            string accion = "";
            string msm = "";
            int id = 0;
            objeto.ApellidoP1 = Emp_ApePat.Text;
            objeto.ApellidoM1 = Emp_ApeMat.Text;
            objeto.Nombre1 = Emp_NomPri.Text;
            objeto.Sexo1 = Emp_Sexo.Text;
            objeto.CURP1 = Emp_CURP.Text;
            objeto.RFC1 = Emp_RFC.Text;
            objeto.Fecha_Na1 = Emp_FecNac.Text;
            objeto.Fecha_ini1 = Emp_FecIni.Text;
            objeto.Fecha_Fin1 = Emp_FecFin.Text;
            dts.Ciudad1 = Emp_CiuNac.Text;
            // objeto.Pais_Na1 = Emp_PaisNac.Text; Campo borrado, no existe en la BD
            //objeto.Nacionalidad1 = Emp_Nacionalidad.Text; Campo borrado, no existe en la BD
            objeto.CiudadNac1 = Emp_CiuNac.Text;
            objeto.Civil1 = Emp_EdoCivil.Text;
            objeto.EstadoNac1 = Emp_EdoNac.Text;

            mensaje = inser.inserta(objeto.Nombre1,objeto.ApellidoP1,objeto.ApellidoM1,objeto.RFC1,0,objeto.CURP1,1);
            accion = mensaje.Substring(0, 1);
            msm = mensaje.Substring(1, mensaje.Length-1);

            id = inser.idEmpleado(objeto.CURP1);
            datosPersonal dtsPe = new datosPersonal(id); // Abrir pantalla de "Datos Personal"

            MessageBox.Show(msm);
            if (accion.Equals("1"))
            {
            dtsPe.Show(); // Abre la vista de Datos Empleados
            this.Hide();  // Cierra la pantalla de empleados
            }
            else {
            this.Hide();
            }

            
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            inser.llenaSexo(Emp_Sexo);
            inser.llenaEdoCivil(Emp_EdoCivil);
        }

        private void btn_Emp_Sig_Click(object sender, EventArgs e) // Boton siguiente, obtiene los datos de la caja de texto de la vista y realiza el Insert a la BD
        {
            insertar();
            Limpiar();
            this.Hide();
        }

        private void btnRegresarE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limpiar();
        }

        private void Limpiar()
        {
            Emp_ApeMat.Text = "";
            Emp_ApePat.Text = "";
            Emp_CiuNac.Text = "";
            Emp_CURP.Text = "";
            Emp_Edad.Text = "";
            Emp_EdoCivil.Text = "";
            Emp_EdoNac.Text = "";
            Emp_FecFin.Text = "";
            Emp_NomPri.Text = "";
            Emp_RFC.Text = "";
            Emp_Sexo.Text = "";
        }

        private void Emp_EdoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }    
}

