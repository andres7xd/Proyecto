using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Conexion;
using System.Drawing;

namespace Proyecto
{
    public class Notas : FlowLayoutPanel
    {
        public static bool Listo ;
        public static int idNotaEstatica;
        public static string titulounico;
        public Button Editar = new Button();
        public Button Eliminar = new Button();
        public  Label Titulo = new Label();
        public Label Nota = new Label();
        public String Categoria;
        public String Privacidad;
        public String NColor;
        public String Fuente;
        public String ColorLetra;
        public String FechaCreacion;
        public String FechaModificacion;

        public Notas(string titulo, string privacidad, string categoria, string color, string fechaCreacion, string fechaModificacion,string nota)
        {
            
            Titulo.Text = titulo;
            Nota.Text = nota;
            Categoria = categoria;
            Privacidad = privacidad;
            NColor = color;
          
            FechaCreacion = fechaCreacion;
            FechaModificacion = fechaModificacion;
            Editar.Text = "EDITAR";
            Eliminar.Text = "ELIMINAR";

          
            Titulo.Width = 100;
            Titulo.Height = 15;
            Nota.Width = 100;
            Nota.Height = 15;
            
            Editar.Width = 100;
            Editar.Height = 25;

            this.Controls.Add(Titulo);
            this.Controls.Add(Nota);
            this.Controls.Add(Editar);
            this.Controls.Add(Eliminar);
          
            if (color == "Rojo")
            {

                this.BackColor = Color.Red;
               
            }
            if (color == "Gris")
            {

                this.BackColor = Color.Gray;
            }
            if (color == "Azul")
            {
                this.BackColor = Color.Blue;
            }
            if (color == "Verde")
            {
                this.BackColor = Color.Green;
            }

            this.Click += new System.EventHandler(AccederNota);
            Titulo.Click += new System.EventHandler(AccederNota);
            Nota.Click += new System.EventHandler(AccederNota);
            Editar.Click += new System.EventHandler(EditarNota);
            Eliminar.Click += new System.EventHandler(EliminarNota);

        }

        void AccederNota(Object s, System.EventArgs h)
        {
           

            Console.WriteLine(Titulo.Text);
            NotasForm notas = new NotasForm();



        }

        void EditarNota(Object s, System.EventArgs h)
        {
            titulounico = Titulo.Text;

            MySqlAccess mySql = new MySqlAccess();
            String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
            mySql.ConnectionString = cn;
            mySql.OpenConnection();
            mySql.BeginTransaction();
            DataTable dataTable = new DataTable();
            String id = String.Format("SELECT idnotas from notas where titulo ='{0}'", titulounico);

            dataTable = mySql.QuerySQL(id);
            int idActual = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            idNotaEstatica = idActual;

            String FechaHistorial = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            string query3 = string.Format("INSERT INTO transacciones(idhistorial,fecha,usuario, accion,objeto,info_adicional,usuarios_idusuario)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
             "0", FechaHistorial, Login.Usuario, "Nota Edittada", "Mantenimiento notas", titulounico, Login.idUsuario);

            mySql.EjectSQL(query3);

            mySql.CommitTransaction();
            mySql.CloseConnection();


            MantenimientoNotas mantenimientoLibros = new MantenimientoNotas();
            mantenimientoLibros.ShowDialog();



        }

        void EliminarNota(Object s, System.EventArgs h)
        {
            titulounico = Titulo.Text;

            MySqlAccess mySql = new MySqlAccess();
            String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
            mySql.ConnectionString = cn;
            mySql.OpenConnection();
            mySql.BeginTransaction();
            DataTable dataTable = new DataTable();
            string query = string.Format("DELETE FROM notas WHERE(titulo = '" + titulounico + "') ");



            mySql.EjectSQL(query);

            String FechaHistorial = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            string query3 = string.Format("INSERT INTO transacciones(idhistorial,fecha,usuario, accion,objeto,info_adicional,usuarios_idusuario)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
             "0", FechaHistorial, Login.Usuario, "Nota Eliminada", "Mantenimiento notas", titulounico, Login.idUsuario);

            mySql.EjectSQL(query3);

            mySql.CommitTransaction();
            mySql.CloseConnection();

            MessageBox.Show("La nota se ha eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }

    
  
}
