using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.OOP.Ejercicio4
{
    public class Ejercicio4
    {
        public void Ejercicio()
        {
            string[] opciones = { "1-Insertar cordenada", "2-Recoger cordenadas", "3-Recoger una cordenada", "4-Editar una cordenada", "5-Obtener distancia entre dos cordenadas", "6-Salir" };
            CoordenadasEvent coordenadasEvent = new CoordenadasEvent();

            int opcion = 6;
            do
            {
                Console.WriteLine("Que desea realizar: ");
                foreach (var accion in opciones)
                {
                    Console.WriteLine(accion);
                }
                opcion = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Id de la cordenada: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("EjeX de la cordenada: ");
                        decimal ejeX = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("EjeY de la cordenada: ");
                        decimal ejeY = Convert.ToDecimal(Console.ReadLine());

                        coordenadasEvent.NewCoordenada(id, ejeX, ejeY);
                        break;
                    case 1:
                        foreach (var cordenada in coordenadasEvent.GetCoordenadas())
                        {
                            Console.WriteLine("La cordenada {0}, tiene como EjeX {1} y EjeY {2}",cordenada.Id, cordenada.EjeX, cordenada.EjeY);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Introduce la id de la cordenada que quieres: ");
                        int cordId = Convert.ToInt32(Console.ReadLine());

                        var cordenadaOnly = coordenadasEvent.GetCoordenada(cordId);
                        Console.WriteLine("La cordenada {0}, tiene como EjeX {1} y EjeY {2}", cordenadaOnly.Id, cordenadaOnly.EjeX, cordenadaOnly.EjeY);
                        break;
                    case 3:
                        Console.WriteLine("Introduce la id de la cordenada que quieres editar: ");
                        int editId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("EjeX de la cordenada: ");
                        decimal editEjeX = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("EjeY de la cordenada: ");
                        decimal editEjeY = Convert.ToDecimal(Console.ReadLine());

                        coordenadasEvent.EditCoordenada(editId, editEjeX, editEjeY);
                        break;
                    case 4:
                        Console.WriteLine("Introduce la id de la cordenada para comparar (1): ");
                        int cordId_1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Introduce la id de la cordenada para comparar (2): ");
                        int cordId_2 = Convert.ToInt32(Console.ReadLine());

                        var (distanciaX, distanciaY) = coordenadasEvent.GetDistancia(cordId_1, cordId_2);

                        Console.WriteLine("La distancia entre las dos cordenadas es: {0} EjeX y {1} EjeY", distanciaX, distanciaY);
                        break;
                }
                Console.WriteLine();
            } while (opcion != 5);
        }
    }
}
