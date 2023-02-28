using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.OOP.Ejercicio3
{
    public class Ejercicio3
    {
        public void Ejercicio()
        {
            Paises paises = new Paises();
            ListPaises listPaises = new ListPaises();
            Random ran = new Random();
            do
            {
                Console.WriteLine("Introduce el nombre de un pais:");
                paises.Pais = Console.ReadLine();

                if (!string.IsNullOrEmpty(paises.Pais))
                {
                    List<int> estatura = new List<int>();
                    for (int i = 0; i < 6; i++)
                    {
                        estatura.Add(ran.Next(140, 210));
                    }
                    
                    paises.Estatura = estatura;
                    listPaises.SetPaises(paises);
                }

            } while (!string.IsNullOrEmpty(paises.Pais));

            //Listar todos los paises y sus estaturas
            foreach(var pais in listPaises.GetPaises())
            {
                Console.Write(pais.Pais+": ");
                foreach(var estatura in pais.Estatura)
                {
                    Console.Write(estatura+" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Sacar la estatura minima y maxima de cada pais
            foreach (var pais in listPaises.GetPaises())
            {
                Console.WriteLine("La estatura minima y maxima de {0} es: {1} MIN y {2} MAX",pais.Pais,pais.Estatura.Min(),pais.Estatura.Max());
            }

            //Sacar la estura minima y maxima de todos los paises
            var estaturas = listPaises.GetPaises().Select(x => x.Estatura).ToList();
            List<int> estaturasMin = new List<int>();
            List<int> estaturasMax = new List<int>();
            foreach (var estatura in estaturas)
            {
                estaturasMin.Add(estatura.Min());
                estaturasMax.Add(estatura.Max());   
            }
            Console.WriteLine("\n La estatura minima y maxima de todos los paises es: {0} MIN y {1} MAX", estaturasMin.Min(), estaturasMax.Max());
        }
        
    }
}
