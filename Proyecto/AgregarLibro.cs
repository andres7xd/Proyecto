using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class AgregarLibro : Form
    {
        public static String Nombre, Color, Orden, Categoria;
        public AgregarLibro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nombre = textNombre.Text;
            Orden = textOrden.Text;
            Color = textColor.Text;
            Categoria = textCategoria.Text;
            this.Close();
        }
    }
}
