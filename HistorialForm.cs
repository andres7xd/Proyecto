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
    public partial class HistorialForm : Form
    {
        static List<Historial> ListaHistorialstatica = Principal.ListaHistorial;

        public HistorialForm()
        {

            InitializeComponent();
            LlenarGrid();
        }

        public void LlenarGrid()

        {
            for(int i=0;i< ListaHistorialstatica.Count; i++)
            {
                dtgHistorial.Rows.Add(ListaHistorialstatica[i].FechaHora, ListaHistorialstatica[i].Usuario, ListaHistorialstatica[i].Accion, ListaHistorialstatica[i].Lugar, ListaHistorialstatica[i].InformacionAdicional);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
