using AplicacionDefinitiva.ContralorDeVentana;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDefinitiva.Datos;
namespace AplicacionDefinitiva.Vistas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ControladorDeVentanas.MostrarLogin();
            etiError.Text = "";
            txbNomUsuario.Text="";
            txbConfiContra.Text = "";
            txbContraseña.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Utilidades.RegistroUsuario(txbNomUsuario.Text, txbContraseña.Text, txbConfiContra.Text);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
