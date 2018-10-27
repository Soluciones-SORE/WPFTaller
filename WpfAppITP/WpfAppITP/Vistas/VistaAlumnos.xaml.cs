using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppITP.ViewModel;

namespace WpfAppITP.Vistas
{
    /// <summary>
    /// Lógica de interacción para VistaAlumnos.xaml
    /// </summary>
    public partial class VistaAlumnos : UserControl
    {
        AlumnoViewModel obj =new AlumnoViewModel();
        public VistaAlumnos()
        {
            InitializeComponent();
            DataContext = obj;

        }

        private void ListaAlumnos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var res = e.Source as ListView;
            var alumno = res.SelectedItem as Modelo.Alumno;
            if(alumno != null)
            {
                obj.Clave = alumno.Clave;
                obj.Nombre = alumno.Nombre;
                obj.Correo = alumno.Correo;
                obj.Telefono = alumno.Telefono;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
               
                "Nombre: "+nom.Text+"\nCorreo: "
                +cor.Text+"\nTelefono: "+tel.Text
                );
            Modelo.Alumno obj = new Modelo.Alumno
            {
                Clave=10,
                Nombre=nom.Text,
                Correo=cor.Text,
                Telefono=tel.Text
            };
            Modificar(obj);


        }
        public void Modificar(Modelo.Alumno parametro)
        {
            for(int i=0;i<obj.Alumnos.Count;i++)
            {
                if(parametro.Nombre== obj.Alumnos[i].Nombre)
                {
                    obj.Alumnos[i] = parametro;
                }
            }
        }
    }
}
