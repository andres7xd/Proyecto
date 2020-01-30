using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using UNA.Conexion;
using System.Data;

namespace Proyecto
{
    public class Libro : FlowLayoutPanel
    {
        
        
        public static string NombreStatico;
        public static string OrdenEstatico;
        public static string CategoriaEstatica;
        public static string ColorEstatico;
        public static int idEstatico;
        public static int idLibroEstatico;

        public  String Colorr;
        public int idLibro;
        public Label Nombre = new Label();
        public Label Orden = new Label();
        public Label Categoria = new Label();
        public Button EditarLibro = new Button();
        public Button EliminarLibro = new Button();
        public List<Notas> notas = new List<Notas>();
       
        public Libro()
        {



        }


        public Libro(string nombre, string lcolor, string orden, string categoria)
        {
            int ordenint;

           



            Colorr = lcolor;
            
            Nombre.Text = nombre;
            EditarLibro.Text = "EDITAR";
            EliminarLibro.Text = "ELIMINAR";

            Orden.Text = orden;
            Categoria.Text = categoria;

            

            Nombre.Width = 100;
            Nombre.Height = 15;

            Orden.Width = 100;
            Orden.Height = 15;
            Categoria.Width = 100;
            Categoria.Height = 15;

            EditarLibro.Width = 60;
            EditarLibro.Height = 25;

            EliminarLibro.Width = 60;
            EliminarLibro.Height = 25;

            Nombre.ForeColor = Color.Gold;

            Orden.ForeColor = Color.Khaki;
            Categoria.ForeColor = Color.LightBlue;

            this.Width = 100;
            this.Height = 110;
            this.Controls.Add(Nombre);

            this.Controls.Add(Orden);
            this.Controls.Add(Categoria);
            this.Controls.Add(EditarLibro);
            this.Controls.Add(EliminarLibro);

            if (lcolor == "Rojo")
            {
                
                this.BackColor = Color.Red;

            }
            if (lcolor == "Gris")
            {
               
                this.BackColor = Color.Gray;
            }
            if (lcolor == "Azul")
            {
                this.BackColor = Color.Blue;
            }
            if (lcolor == "Verde")
            {
                this.BackColor = Color.Green;
            }

            ordenint = Convert.ToInt32(orden);

            MySqlAccess mySql = new MySqlAccess();
            String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
            mySql.ConnectionString = cn;
            mySql.OpenConnection();
            mySql.BeginTransaction();
            DataTable dataTable = new DataTable();
            String id = String.Format("SELECT idlibros from libros where nombre ='{0}'and categoria= '{1}'and color= '{2}'and orden= '{3}'", nombre, categoria, lcolor, ordenint);

            dataTable = mySql.QuerySQL(id);
            int idActual = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            idLibro = idActual;

            mySql.CommitTransaction();
            mySql.CloseConnection();

            this.Click += new System.EventHandler(AccederLibro);
            Nombre.Click += new System.EventHandler(AccederLibro);
            Orden.Click += new System.EventHandler(AccederLibro);
            Categoria.Click += new System.EventHandler(AccederLibro);
            EditarLibro.Click +=new System.EventHandler(Editarlibro);
            EliminarLibro.Click += new System.EventHandler(Eliminarlibro);


        }
        void AccederLibro(Object s, System.EventArgs h)
        {
            NombreStatico = Nombre.Text;
            NotasForm notas = new NotasForm();
            notas.ShowDialog();

            
        }

        void Editarlibro(Object s, System.EventArgs h)
        {
           
            NombreStatico = Nombre.Text;
            OrdenEstatico = Orden.Text;
            CategoriaEstatica = Categoria.Text;
            ColorEstatico = Colorr;
            idLibroEstatico = idLibro;

            Console.WriteLine(idLibroEstatico);

            MantenimientoLibros mantenimientoLibros = new MantenimientoLibros();
            mantenimientoLibros.ShowDialog();


        }

        void Eliminarlibro(Object s, System.EventArgs h)
        {
            idLibroEstatico = idLibro;

            MySqlAccess mySql = new MySqlAccess();
            String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
            mySql.ConnectionString = cn;
            mySql.OpenConnection();
            mySql.BeginTransaction();
            DataTable dataTable = new DataTable();
            string query = string.Format("DELETE FROM libros WHERE(idlibros = '"+idLibroEstatico+"') and(usuarios_idusuario= '"+Login.idUsuario+"')");
            


           mySql.EjectSQL(query);

            mySql.CommitTransaction();
            mySql.CloseConnection();

            MessageBox.Show("El Libro se ha eliminado correctamente, Presione REFRESCAR LIBRO para visualizar el cambio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public int idlibro
        {
            get{
                return idlibro;
            }
            set{
                idlibro = value;
            }
        }

        public List<Notas> ListNotas
        {
            get
            {
                return notas;
            }
            set
            {
                notas = value;
            }
        }
    }
}
