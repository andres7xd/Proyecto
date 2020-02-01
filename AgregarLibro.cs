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
    public partial class AgregarLibro : Form
    {
        public static String Nombre, Color,Orden, Categoria;
        int Ordenint;
        public static int idUsuarioactual;
        String Nusuario = Login.Usuario; 

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public AgregarLibro()
        {
            InitializeComponent();

            cmbCategoria.Items.Add("Fantasia");
            cmbCategoria.Items.Add("Romance");
            cmbCategoria.Items.Add("Historia");
            cmbCategoria.Items.Add("Ciencias");

            cmbColor.Items.Add("Gris");
            cmbColor.Items.Add("Rojo");
            cmbColor.Items.Add("Azul");
            cmbColor.Items.Add("Verde");
            
            cmbColor.SelectedItem="Gris";
            cmbCategoria.SelectedItem = "Fantasia";


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {



            if (textNombre.TextLength != 0 && textOrden.TextLength!= 0)
            {
                Nombre = textNombre.Text;
                Orden = textOrden.Text;
                Color = cmbColor.Text;
                Categoria = cmbCategoria.Text;
                Ordenint = Convert.ToInt32(Orden);

                MySqlAccess mySql = new MySqlAccess();
                String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
                mySql.ConnectionString = cn;
                mySql.OpenConnection();
                mySql.BeginTransaction();
                
                String idusuario = String.Format("SELECT idusuario from usuarios where usuario ='{0}'", Nusuario);
                mySql.QuerySQL(idusuario);
                DataTable dataTable = new DataTable();
               
                dataTable = mySql.QuerySQL(idusuario);
                int idActual = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                idUsuarioactual = idActual;

                string query = string.Format("INSERT INTO libros(idlibros,nombre, categoria,color,orden,usuarios_idusuario)VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                 "0", textNombre.Text, cmbCategoria.Text,cmbColor.Text,Ordenint,idActual);

                //string query = string.Format("INSERT INTO libros('nombre', 'categoria', 'color', 'orden', 'usuarios_idusuario') values('" + textNombre.Text + "','" + (String)cmbCategoria.SelectedItem + "', '" + (String)cmbColor.SelectedItem + "'," + Ordenint + "," + idActual);
               
                String FechaHistorial = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                string query2 = string.Format("INSERT INTO transacciones(idhistorial,fecha,usuario, accion,objeto,info_adicional,usuarios_idusuario)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                 "0", FechaHistorial, Login.Usuario, "Se agega un libro", "Agregar Libros", "Libro agregado correctamente", Login.idUsuario);

                mySql.EjectSQL(query2);

                mySql.EjectSQL(query);

                mySql.CommitTransaction();
                mySql.CloseConnection();

                this.Close();


            }

            if (textNombre.TextLength == 0)
            {

                errorProviderAgregarLibro.SetError(textNombre, "Digite un nombre para el libro");
            }

            if (textOrden.TextLength == 0)
            {

                errorProviderAgregarLibro.SetError(textOrden, "Digite un orden para el libro");
            }

        }
    }
}
