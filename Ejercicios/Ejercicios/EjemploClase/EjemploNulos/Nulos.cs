using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.EjemploNulos
{
    internal class Nulos
    {
        public void ej()
        {
            int? enteroNulable1 = 5;
            int? enteroNulable2 = null;

            int nonula = enteroNulable2 ?? Controlar();

            var z = new { Edad = 35, Nombre = "Paco", ColorPelo = "Blanco" };

            DateTime date = DateTime.Now; // aquí date tendrá la fecha/hora actual
            DateTime date2 = DateTime.MinValue; // día 01/01/0001 00:00:00
            string strDate = DateTime.Now.ToString("dd / MM / yyyy - HH:mm");
            // string con la fecha actual, mostrando el día, mes y año separados por ‘/
            DateTime fecha = new DateTime(2019, 9, 1, 10, 35, 41);
            fecha = fecha.AddDays(-7);

            var dia = fecha.DayOfWeek;

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Now.AddDays(7);
            // el uso principal de Timestamp: tiempo pasado entre dos fechas/horas
            TimeSpan diff = d2 - d1;
            Console.WriteLine(diff);

            //Console.WriteLine(fecha);
            //Console.WriteLine(date2);
            //Console.WriteLine(strDate);
            Console.ReadKey();

            var a = ConsoleColor.Yellow;
        }
        public int Controlar()
        {
            return 3;
        }
       
    }
}
