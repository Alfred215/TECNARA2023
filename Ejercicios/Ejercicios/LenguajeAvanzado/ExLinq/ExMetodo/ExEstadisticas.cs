using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExLinq.ExMetodo
{
    public class ExEstadisticas
    {
        public ExEstadisticas()
        {
            LinqVenta vent1 = new LinqVenta();
            vent1.Id = 1;
            vent1.Fecha = new DateTime(2022, 3, 7);
            vent1.Productos = new List<Producto> { };
            vent1.Productos.Add(new Producto { Nombre = "Cocacola", Precio = 1.95m });
            vent1.Productos.Add(new Producto { Nombre = "Pan", Precio = 0.65m });

            LinqVenta vent2 = new LinqVenta();
            vent2.Id = 2;
            vent2.Fecha = new DateTime(2022, 5, 4);
            vent2.Productos = new List<Producto> { }; 
            vent2.Productos.Add(new Producto { Nombre = "Colgate", Precio = 2.50m });
            vent2.Productos.Add(new Producto { Nombre = "Cocacola", Precio = 1.95m });
            vent2.Productos.Add(new Producto { Nombre = "Cepillo", Precio = 0.99m });

            EstadisticasVenta estVentas = new EstadisticasVenta(new List<LinqVenta>{ vent1, vent2 });

            estVentas.ObtenerVentasPorFecha(new DateTime(2022, 3, 2), new DateTime(2022, 3, 20));
            estVentas.ObtenerVentasPorProducto("Cocacola");
            estVentas.ObtenerTotalVentas();
        }
    }
}
