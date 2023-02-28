using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Interfaz
{
    public class Class1 : Interface1, Interface2
    {
        public void Ejecutar()
        {
            ((Interface1)new Class1()).CalculameEsta();
            ((Interface2)new Class1()).CalculameEsta();
        }

        void Interface1.CalculameEsta()
        {
            Console.WriteLine("hola");
        }
        
        void Interface2.CalculameEsta()
        {
            Console.WriteLine("byee");
        }

        public int AhoraSumaEsta(int numerisimo)
        {
            //Ahora sumas aqui;
            return 0;
        }

        public void EnseñameEsta()
        {

        }
    }
}
