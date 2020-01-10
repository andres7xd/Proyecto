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
