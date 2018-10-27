using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppITP.Modelo;
using WpfAppITP.Servicio;

namespace WpfAppITP.ViewModel
{
    public class AlumnoViewModel:Notificable
    {
        public ObservableCollection<Alumno> Alumnos { get; set; }
        public AlumnoViewModel()
        {
            EjecutaConsulta();
        }


        public void EjecutaConsulta()
        {
            List<Alumno> result = null;
            result = WebService.ConsultaAlumnos();
            Alumnos = new ObservableCollection<Alumno>(result);
        }
        /* propiedades de vewModel
        estas propiedades usaran la
        clase notificable que implementa la interfaz 
        INotifyPropertyChanged
        esto para elnazar la vista y el
        modelo
        */
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
                OnPropertyChange();
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
                OnPropertyChange();
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
                OnPropertyChange();

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
                OnPropertyChange();

            }
        }
    }
}
