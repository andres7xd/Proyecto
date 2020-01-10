using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    class Notas : FlowLayoutPanel
    {
        public  Label Titulo = new Label();
        public Label Nota = new Label();
        public String Categoria;
        public String Privacidad;
        public String Color;
        public String Fuente;
        public String ColorLetra;
        public String FechaCreacion;
        public String FechaModificacion;

        public Notas(string titulo, string nota, string categoria, string privacidad, string color, string fuente, string colorLetra, string fechaCreacion, string fechaModificacion)
        {
            Titulo.Text = titulo;
            Nota.Text = nota;
            Categoria = categoria;
            Privacidad = privacidad;
            Color = color;
            Fuente = fuente;
            ColorLetra = colorLetra;
            FechaCreacion = fechaCreacion;
            FechaModificacion = fechaModificacion;

            Titulo.Width = 100;
            Titulo.Height = 15;
            Nota.Width = 100;
            Nota.Height = 15;

            this.Controls.Add(Titulo);
            this.Controls.Add(Nota);

            this.Click += new System.EventHandler(AccederNota);
            Titulo.Click += new System.EventHandler(AccederNota);
            Nota.Click += new System.EventHandler(AccederNota);

        }

        void AccederNota(Object s, System.EventArgs h)
        {
            //NotasForm notas = new NotasForm();
            //notas.ShowDialog();

            Console.WriteLine(Titulo.Text);
            NotasForm notas = new NotasForm();



        }
    }

    
  
}
