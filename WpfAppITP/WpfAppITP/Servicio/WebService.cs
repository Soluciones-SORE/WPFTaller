using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppITP.Modelo;

namespace WpfAppITP.Servicio
{
    public class WebService
    {
        public static List<Alumno> ConsultaAlumnos()
        {
            return new List<Alumno>
            {
                new Alumno{Clave=1,Nombre="Jesus",Correo="jesusortegarosas10@gmail.com",Telefono="2228119090" },
                new Alumno{Clave=2,Nombre="Eric",Correo="eric_rafa@live.com.mx",Telefono="5544216171" },
                new Alumno{Clave=3,Nombre="Eduardo",Correo="eduardo186@gmail.com",Telefono="225676398" },
                new Alumno{Clave=4,Nombre="cesar",Correo="szm_csa@gmail.com",Telefono="2221273894" }
            };
        }

    }
}
