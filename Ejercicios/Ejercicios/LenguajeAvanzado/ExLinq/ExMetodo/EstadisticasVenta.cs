using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExLinq.ExMetodo
{
    public class EstadisticasVenta
    {
        private List<LinqVenta> _ventas;

        public EstadisticasVenta(List<LinqVenta> vent) {
            _ventas = vent;
        }

        public void ObtenerTotalVentas()
        {
            Console.WriteLine($"El total de importe de todas las ventas es {_ventas.Sum(v => v.Importe)}");
        }

        public void ObtenerVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            Console.WriteLine($"Las ventas de las fechas comprendidas entre {fechaInicio} y {fechaFin} son:");
            _ventas.Where(v => v.Fecha >= fechaInicio && v.Fecha <= fechaFin)
                .ToList()
                .ForEach(x => Console.WriteLine(x.Id +" - "+x.Importe + " - " + x.Fecha));
        }

        public void ObtenerVentasPorProducto(string nombreProd)
        {
            Console.WriteLine($"Las ventas del producto {nombreProd} son:");
           _ventas.Where(x => x.Productos.Any(p => p.Nombre == nombreProd))
                .ToList()
                .ForEach(x => Console.WriteLine(x.Id + " - " + x.Importe + " - " + x.Fecha)); ;
        }
    } 
}
