using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Enumerables
{
    public enum TipoPersona
    {
        [Description("Adulto")]
        Adult = 0,

        [Description("Anciano")]
        OldPerson = 1,

        [Description("Joven")]
        Teen = 2,

        [Description("Bebe")]
        Baby = 3,
    }
}
