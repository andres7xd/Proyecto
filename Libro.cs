using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proyecto
{
    public class Libro : FlowLayoutPanel
    {

        public Label Nombre = new Label();
        public static string NombreStatico;
        public Label Orden = new Label();
        public Label Categoria = new Label();
        public List<Notas> notas = new List<Notas>();
        public Libro()
        {



        }


        public Libro(string nombre, string lcolor, string orden, string categoria)
        {

            Nombre.Text = nombre;

            Orden.Text = orden;
            Categoria.Text = categoria;

            Nombre.Width = 100;
            Nombre.Height = 15;

            Orden.Width = 100;
            Orden.Height = 15;
            Categoria.Width = 100;
            Categoria.Height = 15;
            Nombre.ForeColor = Color.Gold;

            Orden.ForeColor = Color.Khaki;
            Categoria.ForeColor = Color.LightBlue;

            this.Width = 100;
            this.Height = 70;
            this.Controls.Add(Nombre);

            this.Controls.Add(Orden);
            this.Controls.Add(Categoria);

            if (lcolor == "Rojo")
            {
                this.BackColor = Color.Red;
            }
            if (lcolor == "Gris")
            {
                this.BackColor = Color.Gray;
            }
            if (lcolor == "Azul")
            {
                this.BackColor = Color.Blue;
            }
            if (lcolor == "Verde")
            {
                this.BackColor = Color.Green;
            }


            this.Click += new System.EventHandler(AccederLibro);
            Nombre.Click += new System.EventHandler(AccederLibro);
            Orden.Click += new System.EventHandler(AccederLibro);
            Categoria.Click += new System.EventHandler(AccederLibro);


        }
        void AccederLibro(Object s, System.EventArgs h)
        {
            NombreStatico = Nombre.Text;
            NotasForm notas = new NotasForm();
            notas.ShowDialog();

            
        }

        public List<Notas> ListNotas
        {
            get
            {
                return notas;
            }
            set
            {
                notas = value;
            }
        }
    }
}
