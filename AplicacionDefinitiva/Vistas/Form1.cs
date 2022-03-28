using AplicacionDefinitiva.ContralorDeVentana;
using AplicacionDefinitiva.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDefinitiva
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            ControladorDeVentanas.MostrarRegistro();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
            Utilidades.IniciarSesion(txbUsuario.Text, txbContraseña.Text);
            Utilidades.CargarDatos();
            
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timerInicio_Tick(object sender, EventArgs e)
        {

            

        }

        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            if (txbUsuario.Text != " " )
            {

                etiErrorLogin.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
