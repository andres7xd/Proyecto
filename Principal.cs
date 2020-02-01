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
    public partial class Principal : Form
    {
        public static List<Libro> ListaLibros = new List<Libro>();
        public static List<Historial> ListaHistorial = new List<Historial>();
        public static string idusuario;
        public int idusuarioactual ;
        

        public Principal()
        {
            
            InitializeComponent();
           
            idusuarioactual = AgregarLibro.idUsuarioactual;
            btnConfiguracion.Text = Login.Usuario;

           

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            

           

            AgregarLibro agregarLibro = new AgregarLibro();
            agregarLibro.ShowDialog();
             
            flowLayoutPanel1.Controls.Clear();
            Libro lib = new Libro(AgregarLibro.Nombre,AgregarLibro.Color,AgregarLibro.Orden,AgregarLibro.Categoria);

            ListaLibros.Add(lib);

            for(int i =0;i < ListaLibros.Count;i++)
            {
                flowLayoutPanel1.Controls.Add(ListaLibros[i]);
            }

            Historial historial = new Historial(Login.Usuario, "Agrega Libro", "AgregarLibro", "");
            
            ListaHistorial.Add(historial);


          
        }

       

       

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialForm historial = new HistorialForm();
            historial.ShowDialog();

            for (int i=0;i<ListaHistorial.Count;i++)
            {
                

                Console.WriteLine(ListaHistorial[i]);

            }
           
        }
        public List<Libro> LibrosList
        {
            get
            {
                return ListaLibros;
            }
            set
            {

                ListaLibros = value;
            }
        }

       

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            MantenimientoUsuario mantenimientoUsuario = new MantenimientoUsuario();
            mantenimientoUsuario.ShowDialog();

        }

        private void cargarlibros(object sender, EventArgs e)
        {
            MySqlAccess mySqlBD = new MySqlAccess();
            mySqlBD.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mySqlStringConnection"].ConnectionString;

            mySqlBD.OpenConnection();
            DataTable dataTable = new DataTable();
            
            dataTable = mySqlBD.QuerySQL("Select * From libros where usuarios_idusuario ="+ Login.idUsuario + "");
            List<Libro> result = new List<Libro>();
            for(int x = 0; x<dataTable.Rows.Count; x++)
            {
                Libro libro = new Libro(dataTable.Rows[x]["nombre"].ToString(), dataTable.Rows[x]["color"].ToString(), dataTable.Rows[x]["orden"].ToString(), dataTable.Rows[x]["categoria"].ToString());
              
                result.Add(libro);
            }
            
            ListaLibros = result;

            for (int i = 0; i < ListaLibros.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(ListaLibros[i]);
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(siguenteVista);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void siguenteVista()
        {
            Application.Run(new Login());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlAccess mySqlBD = new MySqlAccess();
            mySqlBD.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mySqlStringConnection"].ConnectionString;

            mySqlBD.OpenConnection();
            DataTable dataTable = new DataTable();

            dataTable = mySqlBD.QuerySQL("Select * From libros where usuarios_idusuario =" + Login.idUsuario + "");
            List<Libro> result = new List<Libro>();
            for (int x = 0; x < dataTable.Rows.Count; x++)
            {
                Libro libro = new Libro(dataTable.Rows[x]["nombre"].ToString(), dataTable.Rows[x]["color"].ToString(), dataTable.Rows[x]["orden"].ToString(), dataTable.Rows[x]["categoria"].ToString());
               
                result.Add(libro);
            }

            ListaLibros = result;

            for (int i = 0; i < ListaLibros.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(ListaLibros[i]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlAccess mySqlBD = new MySqlAccess();
            mySqlBD.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mySqlStringConnection"].ConnectionString;

            mySqlBD.OpenConnection();
            DataTable dataTable = new DataTable();
            string busqL=String.Format( "Select *From libros where usuarios_idusuario='{0}'and nombre  like '%{1}%'",Login.idUsuario, txtNombreLibro.Text);
            dataTable = mySqlBD.QuerySQL(busqL);
            List<Libro> result = new List<Libro>();
            for (int x = 0; x < dataTable.Rows.Count; x++)
            {
                Libro libro = new Libro(dataTable.Rows[x]["nombre"].ToString(), dataTable.Rows[x]["color"].ToString(), dataTable.Rows[x]["orden"].ToString(), dataTable.Rows[x]["categoria"].ToString());

                result.Add(libro);
            }

            ListaLibros = result;

            for (int i = 0; i < ListaLibros.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(ListaLibros[i]);
            }
        }
    }
}
