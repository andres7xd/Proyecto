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
    public partial class MantenimientoUsuario : Form
    {
        public MantenimientoUsuario()
        {
            InitializeComponent();
            txtUsuario.Text = Login.Usuario;
            txtContrasena.Text = Login.Contrasena;
            //txtContrasena.Text = Login.con
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtContrasena.Enabled=(true);
          

            btnGuardarDatos.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlAccess mySql = new MySqlAccess();
            String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
            mySql.ConnectionString = cn;
            mySql.OpenConnection();
            mySql.BeginTransaction();
            DataTable dataTable = new DataTable();
            string query = string.Format("UPDATE usuarios SET contraseña = '"+ txtContrasena.Text+ "' WHERE (idusuario ="+Login.idUsuario+")");
            

            mySql.EjectSQL(query);

            mySql.CommitTransaction();
            mySql.CloseConnection();
            this.Close();

        }

        private void MantenimientoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
