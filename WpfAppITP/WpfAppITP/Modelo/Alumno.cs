using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppITP.Modelo
{
    public class Alumno
    {
        private int clave;
        private string nombre;
        private string correo;
        private string telefono;
        public int Clave
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Correo
        {
            get
            {
                return correo;
            }
            set
            {
                correo = value;

            }
        }
        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;

            }
        }
    }
}
