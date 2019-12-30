using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto
{
    public class RegistroUsuario
    {
        string listausuario;
        string listacontrasena ;

       public RegistroUsuario(string contra,string usuario)
        {
            this.listausuario = usuario;
            this.listacontrasena = contra;
        }

        public string Usuario
        {
            get
            {
                return listausuario;
            }
            set
            {
                listausuario = value;
            }
        }
        public string Contrasena
        {
            get
            {
                return listacontrasena;
            }
            set
            {
                listacontrasena = value;
            }
        }
    }
}