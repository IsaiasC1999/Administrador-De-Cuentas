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

namespace AplicacionDefinitiva.Vistas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbRepetirContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarMenu_Click(object sender, EventArgs e)
        {
            Utilidades.RegistroNuevaCuenta(txbUsuarioMenu.Text, txbContraseña.Text);
            txbUsuarioMenu.Text = "";
            txbContraseña.Text = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ControladorDeVentanas.MostrarLogin();



        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilidades.CargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilidades.busqueda();

        }

        private void txbUsuarioMenu_Enter(object sender, EventArgs e)
        {
            if (txbUsuarioMenu.Text != " ")
            {

                etiCorretaMenu.Visible = false;
                etiVerificacion.Visible = false;

            }
        }
    }
}
