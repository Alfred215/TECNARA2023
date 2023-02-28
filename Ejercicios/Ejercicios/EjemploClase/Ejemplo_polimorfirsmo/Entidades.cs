using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.Ejemplo_polimorfirsmo
{
    public class Entidades
    {
        public class InfoTrabajador
        {
            public string DNI { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Direccion { get; set; }
            public DateTime? FechaBaja { get; set; }

            public InfoTrabajador(string dni, string nombre, string apellidos, DateTime fechaNacimiento, string direccion, DateTime? fechaBaja = null)
            {
                DNI = dni;
                Nombre = nombre;
                Apellidos = apellidos;
                FechaNacimiento = fechaNacimiento;
                Direccion = direccion;
                FechaBaja = fechaBaja;
            }
        }

        public class InfoDepTecnologia : InfoTrabajador
        {
            public int AnosExperiencia { get; set; }
            public string Tecnologia { get; set; }

            public InfoDepTecnologia(string dni, string nombre, string apellidos, DateTime fechaNacimiento, string direccion, int anosExperiencia, string tecnologia, DateTime? fechaBaja = null)
                : base(dni, nombre, apellidos, fechaNacimiento, direccion, fechaBaja)
            {
                AnosExperiencia = anosExperiencia;
                Tecnologia = tecnologia;
            }
        }

        public class InfoDepVentas : InfoTrabajador
        {
            public string ZonaComercial { get; set; }

            public InfoDepVentas(string dni, string nombre, string apellidos, DateTime fechaNacimiento, string direccion, string zonaComercial)
                : base(dni, nombre, apellidos, fechaNacimiento, direccion)
            {
                ZonaComercial = zonaComercial;
            }
        }

        public class InfoDireccion : InfoTrabajador
        {
            public string Cargo { get; set; }

            public InfoDireccion(string dni, string nombre, string apellidos, DateTime fechaNacimiento, string direccion, string cargo)
                : base(dni, nombre, apellidos, fechaNacimiento, direccion)
            {
                Cargo = cargo;
            }
        }
    }
}
