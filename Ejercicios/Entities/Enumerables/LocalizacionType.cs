using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Enumerables
{
    public enum LocalizacionType
    {
        [Description("Zaragoza")]
        Zaragoza = 0,
        [Description("Barcelona")]
        Barcelona = 1,
        [Description("Madrid")]
        Madrid = 2,
        [Description("Valencia")]
        Valencia = 3,
        [Description("Huesca")]
        Huesca = 4,
    }
}
