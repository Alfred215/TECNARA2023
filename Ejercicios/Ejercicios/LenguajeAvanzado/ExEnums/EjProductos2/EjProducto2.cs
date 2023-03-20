using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExEnums.EjProductos2
{
    public class EjProducto2
    {
        public void EjercicioDeEjemplo()
        {
            List<Producto> prodList = new List<Producto>();
            prodList.Add(new Producto { Nombre = "Cocaloa", Descripcion = "Zero", Tipo = TipoEnum.bebida });
            prodList.Add(new Producto { Nombre = "Pan", Descripcion = "con semillas", Tipo = TipoEnum.alimento });
            prodList.Add(new Producto { Nombre = "Fanta", Descripcion = "naranja", Tipo = TipoEnum.bebida });
            prodList.Add(new Producto { Nombre = "Cerveza", Descripcion = "con limon", Tipo = TipoEnum.bebida });

            foreach (var item in prodList.Where(x => x.Tipo == TipoEnum.bebida))
            {
                Console.WriteLine("Nombre:" + item.Nombre + " " + item.Descripcion + " -> Tipo:" + item.Tipo);
            }
        }
    }
}
