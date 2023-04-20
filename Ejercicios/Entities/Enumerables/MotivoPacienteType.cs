using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Enumerables
{
    public enum MotivoPacienteType
    {
        [Description("Malestar")]
        Malestar = 0,
        [Description("Fiebre")]
        Fiebre = 1,
        [Description("Resfriado")]
        Resfriado = 2,
        [Description("Rotura")]
        Rotura = 3,
        [Description("Accidente")]
        Accidente = 4,
    }
}
