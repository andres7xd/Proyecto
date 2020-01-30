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
    public partial class MantenimientoLibros : Form
    {
        public MantenimientoLibros()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MantenimientoLibros_Load(object sender, EventArgs e)
        {
            textNombre.Text = Libro.NombreStatico;
            cmbCategoria.Text=Libro.CategoriaEstatica;
            textOrden.Text = Libro.OrdenEstatico;
            cmbColor.Text = Libro.ColorEstatico;
           
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            MySqlAccess mySql = new MySqlAccess();
            String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
            mySql.ConnectionString = cn;
            mySql.OpenConnection();
            mySql.BeginTransaction();
            DataTable dataTable = new DataTable();
            string query = string.Format("UPDATE libros SET nombre = '" + textNombre.Text + "', categoria='"+cmbCategoria.Text+ "', color='" + cmbColor.Text + "', orden='" + textOrden.Text + "' WHERE (idlibros =" + Libro.idLibroEstatico + ")");


            mySql.EjectSQL(query);

            mySql.CommitTransaction();
            mySql.CloseConnection();
            this.Close();
        }
    }
}
