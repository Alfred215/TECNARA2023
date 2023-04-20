using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Enumerables
{
    public enum EstadoPersonaType
    {
        [Description("Estudiante")]
        Estudiante = 0,
        [Description("Empleado/a")]
        Empleado = 1,
        [Description("Desempleado/a")]
        Desempleado = 2,
        [Description("Empresario/a")]
        Empresario = 3,
        [Description("Jubilado")]
        Jubilado = 4,
    }
}
