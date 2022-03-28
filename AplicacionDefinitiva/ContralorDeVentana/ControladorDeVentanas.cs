using AplicacionDefinitiva.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDefinitiva.ContralorDeVentana
{
    class ControladorDeVentanas
    {

        public static Form1 Login = new Form1();
        public static Form2 Registro = new Form2();
        public static Form3 Menu = new Form3();

        

        public static void ocultarTodas() 
        {
            Login.Hide();
            Registro.Hide();
            Menu.Hide();
                    
        
        }

        public static void MostrarRegistro ()
        {
            ocultarTodas();
            Registro.Show();

        }


        public static void MostrarLogin () 
        {

            ocultarTodas();
            Login.Show();
        
        
        }

        public static void MostraMenu()
        {

            ocultarTodas();
            Menu.Show();


        }

    }
}
