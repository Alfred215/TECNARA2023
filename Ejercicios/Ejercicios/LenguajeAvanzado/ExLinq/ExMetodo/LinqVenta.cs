using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExLinq.ExMetodo
{
    public class LinqVenta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<Producto> Productos { get; set; }
        public decimal Importe 
        {
            get { return Productos.Sum(x => x.Precio); } 
        }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
