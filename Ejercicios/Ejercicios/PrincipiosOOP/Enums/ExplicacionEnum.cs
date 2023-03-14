using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Enums
{
    internal class ExplicacionEnum
    {

        enum Days { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday };

        enum BoilingPoints { Celsius = 100, Fahrenheit = 212 };

        [Flags]
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

        enum ArrivalStatus { Late = -1, OnTime = 0, Early = 1 };

        public void Explain()
        {

            Type weekdays = typeof(Days);
            Console.WriteLine("The days of the week, and their corresponding values in the Days Enum are:");

            foreach (string s in Enum.GetNames(weekdays))
                Console.WriteLine("{0,-11}= {1}", s, Enum.Format(weekdays, Enum.Parse(weekdays, s), "d"));

            //Output:
            //The days of the week, and their corresponding values in the Days Enum are:
            //Saturday = 0
            //Sunday = 1
            //Monday = 2
            //Tuesday = 3
            //Wednesday = 4
            //Thursday = 5
            //Friday = 6


            Type boiling = typeof(BoilingPoints);

            Console.WriteLine();
            Console.WriteLine("Enums can also be created which have values that represent some meaningful amount.");
            Console.WriteLine("The BoilingPoints Enum defines the following items, and corresponding values:");

            foreach (string s in Enum.GetNames(boiling))
                Console.WriteLine("{0,-11}= {1}", s, Enum.Format(boiling, Enum.Parse(boiling, s), "d"));

            //Output:
            //Enums can also be created which have values that represent some meaningful amount.
            //The BoilingPoints Enum defines the following items, and corresponding values:
            //Celsius = 100
            //Fahrenheit = 212



            Colors myColors = Colors.Red | Colors.Blue | Colors.Yellow;
            Console.WriteLine();
            Console.WriteLine("myColors holds a combination of colors. Namely: {0}", myColors);

            //Output: 
            //myColors holds a combination of colors. Namely: Red, Blue, Yellow



            ArrivalStatus status = ArrivalStatus.OnTime;
            Console.WriteLine("Arrival Status: {0} ({0:D})", status);

            ArrivalStatus status2 = (ArrivalStatus)1;
            Console.WriteLine("Arrival Status: {0} ({0:D})", status2);

            //Output: 
            //Arrival Status: OnTime(0)
            //Arrival Status: Early(1)  
        }
    }
}
