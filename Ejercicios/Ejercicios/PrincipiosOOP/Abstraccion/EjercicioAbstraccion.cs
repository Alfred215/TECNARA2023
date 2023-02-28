using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Abstraccion
{
    public class EjercicioAbstraccion
    {
        /*En este ejemplo, la clase abstracta Shape define el método GetArea, 
         * pero no proporciona una implementación. Las clases concretas Circle 
         * y Rectangle derivan de la clase Shape y proporcionan sus propias 
         * implementaciones del método GetArea. En el método Main, se crean 
         * objetos de cada una de las clases y se llama al método GetArea.*/
        public EjercicioAbstraccion() {
            Circle circle = new Circle(3);
            Rectangle rectangle = new Rectangle(3, 4);

            Console.WriteLine("El area del circulo es: " + circle.GetArea());
            Console.WriteLine("El area del cuadrado es: " + rectangle.GetArea());
        }
    }
}
