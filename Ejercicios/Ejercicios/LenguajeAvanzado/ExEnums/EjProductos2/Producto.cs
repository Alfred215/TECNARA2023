using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExEnums.EjProductos2
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TipoEnum Tipo { get; set; }

    }

    public enum TipoEnum
    {
        alimento,
        bebida,
        electronico
    }
}
