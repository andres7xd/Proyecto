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
    class Historial : FlowLayoutPanel
    {


        public Label Usuario = new Label();
        public Label FechaHora = new Label();
        public Label Accion = new Label();



      public Historial(string usuario,string fechahora,string accion)
        {
            Usuario.Text = usuario;
            FechaHora.Text = fechahora;
            Accion.tetx = accion;

            Usuario.Width = 100;
            Usuario.Height = 15;
            FechaHora.Width = 100;
            FechaHora.Height = 15;
            Accion.Width = 100;
            Accion.Height = 15;

            this.Controls.Add(Usuario);
            this.Controls.Add(FechaHora);
            this.Controls.Add(Accion);



        }
    }
}
