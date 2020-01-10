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
    public partial class Principal : Form
    {
        public static List<Libro> ListaLibros = new List<Libro>();
        public static List<Historial> ListaHistorial = new List<Historial>();

        public Principal()
        {
            
            InitializeComponent();
            LblUsuario.Text = Login.Usuario;

        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {

            AgregarLibro agregarLibro = new AgregarLibro();
            agregarLibro.ShowDialog();
             
            flowLayoutPanel1.Controls.Clear();
            Libro lib = new Libro(AgregarLibro.Nombre,AgregarLibro.Color,AgregarLibro.Orden,AgregarLibro.Categoria);

            ListaLibros.Add(lib);

            for(int i =0;i < ListaLibros.Count;i++)
            {
                flowLayoutPanel1.Controls.Add(ListaLibros[i]);
            }

            Historial historial = new Historial(Login.Usuario, "Agrega Libro", "AgregarLibro", "");
            
            ListaHistorial.Add(historial);


          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialForm historial = new HistorialForm();
            historial.ShowDialog();

            for (int i=0;i<ListaHistorial.Count;i++)
            {
                

                Console.WriteLine(ListaHistorial[i]);

            }
           
        }
        public List<Libro> LibrosList
        {
            get
            {
                return ListaLibros;
            }
            set
            {

                ListaLibros = value;
            }
        }
    }
}
