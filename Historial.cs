using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public class Historial
    {


        public String Usuario;
        public String FechaHora;
        public String Accion ;
        public String Lugar;
        public String InformacionAdicional;



        public  Historial(String usuario,String accion, String lugar,String infoadicional)
        {


            FechaHora = DateTime.Now.ToString("ddd dd MMM yyyy h:mm:ss  tt");

            Usuario = usuario;
            Accion = accion;
            Lugar = lugar;
            InformacionAdicional = infoadicional;



        }
    }
}
