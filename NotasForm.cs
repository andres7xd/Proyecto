using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Conexion;

namespace Proyecto
{
    public partial class NotasForm : Form
    {
        private int idusuario = Login.idUsuario;
        private int idlibro = Libro.idLibroEstatico;
        List<Notas> ListaNotas = new List<Notas>();
        static List<Historial> ListaHistorialstatica = Principal.ListaHistorial;
        

        public NotasForm()
        {


            InitializeComponent();

   

            cmbCategoria.Items.Add("Importante");
            cmbCategoria.Items.Add("Expontanea");
            cmbCategoria.Items.Add("Inconclusa");

            cmbPrivacidad.Items.Add("Publica");
            cmbPrivacidad.Items.Add("Privada");

            cmbColor.Items.Add("Azul");
            cmbColor.Items.Add("Gris");
            cmbColor.Items.Add("Verde");
            cmbColor.Items.Add("Cafe");

            cmbFuente.Items.Add("Arial");
            cmbFuente.Items.Add("Rive");
            cmbFuente.Items.Add("Calibri");

            cmbColorLetra.Items.Add("Rojo");
            cmbColorLetra.Items.Add("Amarillo");
            cmbColorLetra.Items.Add("Verde");
            cmbColorLetra.Items.Add("Azul");

            textFechaCreacion.Text = DateTime.Now.Day.ToString()+ "/"+ DateTime.Now.Month.ToString()+ "/" + DateTime.Now.Year.ToString();
            textFechaModificacion.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            MySqlAccess mySqlBD = new MySqlAccess();
            mySqlBD.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mySqlStringConnection"].ConnectionString;

            mySqlBD.OpenConnection();
            DataTable dataTable = new DataTable();

            dataTable = mySqlBD.QuerySQL("Select * From notas where libros_idlibros =" + Libro.idLibroEstatico + "");
            List<Notas> result = new List<Notas>();

            for (int x = 0; x < dataTable.Rows.Count; x++)
            {
                Notas notas = new Notas(dataTable.Rows[x]["titulo"].ToString(), dataTable.Rows[x]["privacidad"].ToString(), dataTable.Rows[x]["categoria"].ToString(), dataTable.Rows[x]["notascol"].ToString(), dataTable.Rows[x]["fecha_creacion"].ToString(), dataTable.Rows[x]["fecha_modificacion"].ToString(), dataTable.Rows[x]["texto_notas"].ToString());

                result.Add(notas);
            }

            ListaNotas = result;

            for (int i = 0; i < ListaNotas.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(ListaNotas[i]);
            }


    

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(idusuario);
            Console.WriteLine(idlibro);
            Notas not = new Notas(textTitulo.Text, cmbPrivacidad.Text,cmbCategoria.Text,cmbColor.Text,textFechaCreacion.Text,textFechaModificacion.Text, richTextBoxNota.Text);

            ListaNotas.Add(not);

            for (int i = 0; i < ListaNotas.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(ListaNotas[i]);
            }

            for(int i = 0; i < Principal.ListaLibros.Count; i++)
            {
                if (Principal.ListaLibros[i].Nombre.Text == Libro.NombreStatico)
                {
                    Principal.ListaLibros[i].ListNotas = ListaNotas;
                }
            }

            MySqlAccess mySql = new MySqlAccess();
            String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
            mySql.ConnectionString = cn;
            mySql.OpenConnection();
            mySql.BeginTransaction();



            string query = string.Format("INSERT INTO notas(idnotas,titulo, privacidad,categoria,notascol,fecha_creacion,fecha_modificacion,texto_notas,libros_idlibros,libros_usuarios_idusuario)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
             "0", textTitulo.Text, cmbPrivacidad.Text, cmbCategoria.Text, cmbColor, textFechaCreacion.Text, textFechaModificacion.Text, richTextBoxNota.Text, idlibro, idusuario);

           

            mySql.EjectSQL(query);

            mySql.CommitTransaction();
            mySql.CloseConnection();


            

            Historial historial = new Historial(Login.Usuario, "Agrega Nota", "Notas", "");

            ListaHistorialstatica.Add(historial);

        }



        public void setTxt(string titulo, string nota, string categoria, string privacidad, string color, string fuente, string colorLetra, string fechaCreacion, string fechaModificacion)
        {
            textTitulo.Text = titulo;
            richTextBoxNota.Text = nota;
            cmbCategoria.Text = categoria;
            cmbPrivacidad.Text = privacidad;
            cmbColor.Text = color;
            cmbFuente.Text = fuente;
            cmbColorLetra.Text = colorLetra;
            textFechaCreacion.Text = fechaCreacion;
            textFechaModificacion.Text = fechaModificacion;

        }

        
        

        

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlAccess mySqlBD = new MySqlAccess();
            mySqlBD.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mySqlStringConnection"].ConnectionString;

            mySqlBD.OpenConnection();
            DataTable dataTable = new DataTable();

            dataTable = mySqlBD.QuerySQL("Select * From notas where libros_idlibros =" + Libro.idLibroEstatico + "");
            List<Notas> result = new List<Notas>();

            for (int x = 0; x < dataTable.Rows.Count; x++)
            {
                Notas notas = new Notas(dataTable.Rows[x]["titulo"].ToString(), dataTable.Rows[x]["privacidad"].ToString(), dataTable.Rows[x]["categoria"].ToString(), dataTable.Rows[x]["notascol"].ToString(), dataTable.Rows[x]["fecha_creacion"].ToString(), dataTable.Rows[x]["fecha_modificacion"].ToString(), dataTable.Rows[x]["texto_notas"].ToString());

                result.Add(notas);
            }

            ListaNotas = result;

            for (int i = 0; i < ListaNotas.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(ListaNotas[i]);
            }
        }
    }
}