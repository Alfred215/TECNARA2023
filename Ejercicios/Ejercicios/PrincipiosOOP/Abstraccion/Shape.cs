using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Abstraccion
{
    /*Abstracción: es un concepto que permite centrarse en los aspectos 
     * esenciales de un objeto y omitir los detalles irrelevantes.*/

    abstract class Shape
    {
        public abstract double GetArea();
    }
    
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {

        }

        public Circle(double r)
        {
            radius = r;
        }
        public override double GetArea()
        {
           return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }
}
