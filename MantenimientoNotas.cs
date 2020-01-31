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
    public partial class MantenimientoNotas : Form
    {
        public MantenimientoNotas()
        {
            InitializeComponent();
        }

        private void MantenimientoNotas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

            MySqlAccess mySql = new MySqlAccess();
            String cn = "Server=localhost;Database=Database;Uid=root;Pwd=1234;";
            mySql.ConnectionString = cn;
            mySql.OpenConnection();
            mySql.BeginTransaction();
            DataTable dataTable = new DataTable();
            string query = string.Format("UPDATE notas SET titulo = '" + textTitulo.Text + "', privacidad='" + cmbPrivacidad.Text + "', categoria='" + cmbCategoria.Text + "', notascol='" + cmbColor.Text + "', fecha_modificacion='" + textFechaModificacion.Text + "', texto_notas='" + richTextBoxNota.Text + "' WHERE (idnotas =" + Notas.idNotaEstatica + ")");

            mySql.EjectSQL(query);

            mySql.CommitTransaction();
            mySql.CloseConnection();
            this.Close();

        }
    }
}
