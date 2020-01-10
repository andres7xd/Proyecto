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

namespace Proyecto
{
    public partial class Login : Form
    {
        static List<Historial> ListaHistorialstatica = Principal.ListaHistorial;
        Principal Form1 = new Principal();
        
        List<RegistroUsuario> ListaUsuario = new List<RegistroUsuario>();
        public static string Usuario;
       

        public Login()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < ListaUsuario.Count; i++)
            {
                if(ListaUsuario[i].Usuario == txtUsuario.Text && ListaUsuario[i].Contrasena == txtContraseña.Text)
                {
                    Usuario = ListaUsuario[i].Usuario;
                    Principal n = new Principal();
                    this.Close();
                    Thread thread = new Thread(siguenteVista);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();

                    Historial historial = new Historial(Login.Usuario, "Ingreso al sistema", "Login", "");

                    ListaHistorialstatica.Add(historial);

                }

            }
            
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
