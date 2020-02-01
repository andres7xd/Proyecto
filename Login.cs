
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Conexion;

namespace Proyecto
{
    public partial class Login : Form
    {
        static List<Historial> ListaHistorialstatica = Principal.ListaHistorial;
        Principal Form1 = new Principal();
        
        List<RegistroUsuario> ListaUsuario = new List<RegistroUsuario>();
        public static string Usuario;
        public static string Contrasena;
        public static int idUsuario;
        public static int idUsuarioRegistrado;


        public Login()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            MySqlAccess mySql = new MySqlAccess();
            String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
            mySql.ConnectionString = cn;
            mySql.OpenConnection();
            mySql.BeginTransaction();
            DataTable dataTable = new DataTable();
            String id = String.Format("SELECT idusuario from usuarios where usuario ='{0}'and contraseña= '{1}'", txtUsuario.Text, txtContraseña.Text);
  
            dataTable = mySql.QuerySQL(id);
            if (dataTable.Rows.Count > 0)
            {
                int idActual = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                idUsuario = idActual;
               
                Usuario = txtUsuario.Text;
                Contrasena = txtContraseña.Text;



                String FechaHistorial = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                
                Principal n = new Principal();
                this.Close();
                Thread thread = new Thread(siguenteVista);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

                Historial historial = new Historial(Login.Usuario, "Ingreso al sistema", "Login", "");

                ListaHistorialstatica.Add(historial);

                string query = string.Format("INSERT INTO transacciones(idhistorial,fecha,usuario, accion,objeto,info_adicional,usuarios_idusuario)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                 "0",FechaHistorial, txtUsuario.Text, "Ingreso al sistema", "Login","En ruta a ventana principal",idUsuario);
                mySql.EjectSQL(query);

                dataTable.Clear();
            }
            
          
            
            mySql.CommitTransaction();
            mySql.CloseConnection();

           
            
        }
        private void siguenteVista()
        {
            Application.Run(new Principal());
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            RegistroUsuario usuario;
            if (txtUsuario.TextLength!=0 && txtContraseña.TextLength != 0)
            {
                usuario = new RegistroUsuario(txtContraseña.Text, txtUsuario.Text);
                
                ListaUsuario.Add(usuario);
                Historial historial = new Historial(txtUsuario.Text, "Usuario Registrado", "Login", "");
                ListaHistorialstatica.Add(historial);

                MySqlAccess mySql = new MySqlAccess();
                String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
                mySql.ConnectionString = cn;
                mySql.OpenConnection();
                mySql.BeginTransaction();
                string query = string.Format("INSERT INTO usuarios(idusuario,usuario, contraseña)VALUES('{0}','{1}','{2}')",
                 "0", txtUsuario.Text, txtContraseña.Text);
                mySql.EjectSQL(query);

                DataTable dataTable2 = new DataTable();
                String idusuarioregistrado = String.Format("SELECT idusuario from usuarios where usuario ='{0}'and contraseña= '{1}'", txtUsuario.Text, txtContraseña.Text);
                dataTable2 = mySql.QuerySQL(idusuarioregistrado);
                int idActual = Convert.ToInt32(dataTable2.Rows[0][0].ToString());
                idUsuarioRegistrado = idActual;

                Console.WriteLine(idUsuarioRegistrado);

                String FechaHistorial = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                string query2 = string.Format("INSERT INTO transacciones(idhistorial,fecha,usuario, accion,objeto,info_adicional,usuarios_idusuario)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                 "0", FechaHistorial, txtUsuario.Text, "Se registro un usuario", "Login", "Usuario agregado correctamente", idUsuarioRegistrado);
              
                mySql.EjectSQL(query2);
                mySql.CommitTransaction();
                mySql.CloseConnection();

            }

            if (txtUsuario.TextLength == 0)
            {
                
                LoginErrorProvider.SetError(txtUsuario, "Digite un nombre de usuario");
            }
            if (txtContraseña.TextLength == 0)
            {

                LoginErrorProvider.SetError(txtContraseña, "Digite un nombre de contraseña");
              
            }

             
        
           

        }

    
    }
}
