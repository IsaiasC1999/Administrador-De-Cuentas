using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDefinitiva.ContralorDeVentana;
namespace AplicacionDefinitiva.Datos
{
    class Utilidades
    {

        

        private static int idPersona;

        public static void busqueda ()
        {
            string cadena4 = "server = localhost ; database = ProyectoAgenda;integrated security = true ";

            var conec5 = new SqlConnection(cadena4);

            string ordenBusqueda = "select Cuenta,Contraseña from DatosUsuarios where Cuenta = @Cuenta";

            

            SqlCommand comando4 = new SqlCommand(ordenBusqueda, conec5);

            comando4.Parameters.AddWithValue("Cuenta", ControladorDeVentanas.Menu.TxbBusqueda.Text);


            var adaptor4 = new SqlDataAdapter(comando4);

            DataTable dt = new DataTable();

            adaptor4.Fill(dt);


            ControladorDeVentanas.Menu.DgvCuentas.DataSource = dt;


        }
        

        
        public static  void CargarDatos()
        {
            string cadena2 = "server = localhost ; database = ProyectoAgenda;integrated security = true ";
            SqlConnection con3 = new SqlConnection(cadena2);

            string query = "select Cuenta,Contraseña from DatosUsuarios Where idPersona = @idPersona ";

            SqlCommand comando4 = new SqlCommand(query, con3);

            comando4.Parameters.AddWithValue("idPersona", idPersona); 

            var adator = new SqlDataAdapter(comando4);

            DataTable dt = new DataTable();
            adator.Fill(dt);

            ControladorDeVentanas.Menu.DgvCuentas.DataSource = dt;


            
        }


        public static void RegistroNuevaCuenta(string usuMenu,string ContaMenu)
        {

            if (usuMenu != "" && ContaMenu!= "")
            {

                string cadena2 = "server = localhost ; database = ProyectoAgenda;integrated security = true ";

                SqlConnection con3 = new SqlConnection(cadena2);
                con3.Open();
                string query3 = "insert into DatosUsuarios(Cuenta,Contraseña,idPersona) values(@Cuenta,@Contraseña,@idPersona)";


                SqlCommand coman3 = new SqlCommand(query3, con3);


                coman3.Parameters.AddWithValue("Cuenta", usuMenu);
                coman3.Parameters.AddWithValue("Contraseña", ContaMenu);
                coman3.Parameters.AddWithValue("idPersona", Utilidades.idPersona);

                var gg = coman3.ExecuteNonQuery();


                


                con3.Close();
                ControladorDeVentanas.Menu.EtiCorretaMenu.Visible = true;
                ControladorDeVentanas.Menu.TxbUsuarioMenu.Text = "";
                ControladorDeVentanas.Menu.TxbContraseña.Text = "";

                CargarDatos();

            }

            else
            {
                ControladorDeVentanas.Menu.EtiVerificacion.Visible = true;
                
                ControladorDeVentanas.Menu.TxbUsuarioMenu.Text = "";
                ControladorDeVentanas.Menu.TxbContraseña.Text = "";

            }






        } 



        // Con este Metodo esta la logica del inicio de Sesion 
        public static void IniciarSesion(string usu , string Contra) 
        {

            string candena = " server = localhost; database = ProyectoAgenda; integrated security =  true ";
            SqlConnection conec2 = new SqlConnection(candena);

            conec2.Open();


            string query = "select * from CuentasUsuarios Where Usuario = @usuario and Contraseña = @contraseña ";


            SqlCommand comando = new SqlCommand(query, conec2);

            comando.Parameters.AddWithValue("usuario", usu);
            comando.Parameters.AddWithValue("contraseña", Contra);


            var gg = comando.ExecuteReader();

            if (gg.Read())
            {
                ControladorDeVentanas.MostraMenu();

                Utilidades.idPersona = gg[0].GetHashCode();



                ControladorDeVentanas.Menu.Dasdjaskldjakld.Text = idPersona.ToString();

                ControladorDeVentanas.Login.TxbUsuario.Text = "";
                ControladorDeVentanas.Login.TxbContraseña.Text = "";


            }
            else
            {
                ControladorDeVentanas.Login.EtiErrorLogin.Visible = true;

                ControladorDeVentanas.Login.TxbUsuario.Text = "";
                ControladorDeVentanas.Login.TxbContraseña.Text = "";


                

                
                
                
            }


            conec2.Close();

            

        }
         
        // Este metodo Registra los Usuarios en tabla Llamada CuentasUsuarios
      
        public static void RegistroUsuario (string usu , string contra , string reContraseña)
        {
            if (contra.Equals(reContraseña) && contra != ""  && usu != "")
            {
                string candena = " server = localhost; database = ProyectoAgenda; integrated security =  true ";

                var coneccion = new SqlConnection(candena);

                coneccion.Open();

                string query = "insert Into CuentasUsuarios(Usuario,Contraseña) values ( @usuario , @contraseña  ); ";



                SqlCommand comando = new SqlCommand(query, coneccion);

                comando.Parameters.AddWithValue("usuario", usu);
                comando.Parameters.AddWithValue("Contraseña", contra);

                var ejecutar = comando.ExecuteReader();
                coneccion.Close();
                ControladorDeVentanas.Registro.EtiError.Text = "Usted se ha registrado con exito ";
                
                    
            }
            else
            {

                ControladorDeVentanas.Registro.EtiError.Text = "Las contraseñas no coinciden.\n Por favor ingrese los datos nuevamente... ";
                ControladorDeVentanas.Registro.TxbNomUsuario.Text = "";
                ControladorDeVentanas.Registro.TxbContraseña.Text = "";
                ControladorDeVentanas.Registro.TxbConfiContra.Text = "";


            }
                
               

        }            


    }
}
