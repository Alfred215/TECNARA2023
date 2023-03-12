using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums.EjProductos
{
    internal class EjProducto
    {
        public void comprar()
        {
            // Crear un objeto de la clase Producto y asignar valores a sus propiedades
            Producto producto1 = new Producto();
            producto1.Nombre = "Manzanas";
            producto1.Descripcion = "Una bolsa de manzanas frescas";
            producto1.Tipo = TipoProducto.Alimento;

            // Mostrar en consola el valor de la propiedad Tipo del objeto creado utilizando el enum correspondiente
            Console.WriteLine("El producto 1 es del tipo " + producto1.Tipo);

            // Crear una lista de objetos Producto
            List<Producto> listaProductos = new List<Producto>();
            listaProductos.Add(producto1);

            Producto producto2 = new Producto();
            producto2.Nombre = "Coca-Cola";
            producto2.Descripcion = "Refresco de cola";
            producto2.Tipo = TipoProducto.Bebida;

            listaProductos.Add(producto2);

            Producto producto3 = new Producto();
            producto3.Nombre = "Smartphone";
            producto3.Descripcion = "Un teléfono móvil inteligente";
            producto3.Tipo = TipoProducto.Electronico;

            listaProductos.Add(producto3);

            // Mostrar en consola solo aquellos productos que sean del tipo Bebida
            Console.WriteLine("Productos del tipo Bebida:");
            foreach (Producto producto in listaProductos)
            {
                if (producto.Tipo == TipoProducto.Bebida)
                {
                    Console.WriteLine("- " + producto.Nombre);
                }
            }

            Console.ReadKey();
        }
    }
}
