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
    public partial class NotasForm : Form
    {

        List<Notas> ListaNotas = new List<Notas>();



        public NotasForm()
        {


            InitializeComponent();


            cmbCategoria.Items.Add("Importante");
            cmbCategoria.Items.Add("Expontanea");
            cmbCategoria.Items.Add("Inconclusa");

            cmbPrivacidad.Items.Add("Publica");
            cmbPrivacidad.Items.Add("Privacidad");

            cmbColor.Items.Add("Azul");
            cmbColor.Items.Add("Gris");
            cmbColor.Items.Add("Verde");
            cmbColor.Items.Add("Cafe");

            cmbFuente.Items.Add("Arial");
            cmbFuente.Items.Add("Rive");
            cmbFuente.Items.Add("Calibri");
            textFechaCreacion.Text = DateTime.Now.Day.ToString()+ "/"+ DateTime.Now.Month.ToString()+ "/" + DateTime.Now.Year.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Notas not = new Notas(textTitulo.Text,richTextBoxNota.Text,cmbCategoria.Text,cmbPrivacidad.Text,cmbColor.Text,cmbFuente.Text,cmbColorLetra.Text,textFechaCreacion.Text,textFechaModificacion.Text);

            ListaNotas.Add(not);

            for (int i = 0; i < ListaNotas.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(ListaNotas[i]);
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Notas_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

    }
}