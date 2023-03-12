using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums.EjProductos
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TipoProducto Tipo { get; set; }
    }

    public enum TipoProducto
    {
        Alimento,
        Bebida,
        Electronico
    }

}
