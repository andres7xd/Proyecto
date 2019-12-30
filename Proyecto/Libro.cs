using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Proyecto
{
    class Libro : FlowLayoutPanel
    {

        public Label Nombre = new Label();
        public Label LColor = new Label();
        public Label Orden = new Label();
        public Label Categoria = new Label();

        public Libro()
        {

        }


        public Libro(string nombre, string lcolor, string orden, string categoria)
        {

            Nombre.Text = nombre;
            LColor.Text = lcolor;
            Orden.Text = orden;
            Categoria.Text = categoria;

            Nombre.Width = 100;
            Nombre.Height = 15;
            LColor.Width = 100;
            LColor.Height = 15;
            Orden.Width = 100;
            Orden.Height = 15;
            Categoria.Width = 100;
            Categoria.Height = 15;
            Nombre.ForeColor = Color.Gold;
            LColor.ForeColor = Color.Moccasin;
            Orden.ForeColor = Color.Khaki;
            Categoria.ForeColor = Color.LightBlue;

            this.Width = 100;
            this.Height = 70;
            this.Controls.Add(Nombre);
            this.Controls.Add(LColor);
            this.Controls.Add(Orden);
            this.Controls.Add(Categoria);
            this.BackColor = Color.Gray;

            this.Click += new System.EventHandler(AccederLibro);
            Nombre.Click += new System.EventHandler(AccederLibro);
            Orden.Click += new System.EventHandler(AccederLibro);
            Categoria.Click += new System.EventHandler(AccederLibro);
            LColor.Click += new System.EventHandler(AccederLibro);

        }
       void AccederLibro(Object s,System.EventArgs h)
        {

            Console.WriteLine(Nombre.Text);
        }
    }
}
