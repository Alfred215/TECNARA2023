using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExEnums
{
    internal class ExplicacionEnum2
    {
        public ExplicacionEnum2()
        {
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            Console.WriteLine(meetingDays);
            //Output: Monday, Wednesday, Friday

            Days workingFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
            //Output: Join a meeting by phone on Fridays

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
            //Output: Is there a meeting on Tuesday: False

            var a = (Days)37;
            Console.WriteLine(a);
            //Output: Monday, Wednesday, Saturday   -> not working

            Season s = Season.Autumn;
            Console.WriteLine($"Integral value of {s} is {(int)s}");
            //Output: Integral value of Autumn is 2

            var b = (Season)1;
            Console.WriteLine(b);
            //Output: Summer

            var c = (Season)4;
            Console.WriteLine(c);
            //Output: 4   -> Out of bounds of Season
        }

    }
    public enum Days
    {
        None = 0b_0000_0000,
        Monday = 0b_0000_0001,
        Tuesday = 0b_0000_0010,
        Wednesday = 0b_0000_0100,
        Thursday = 0b_0000_1000,
        Friday = 0b_0001_0000,
        Saturday = 0b_0010_0000,
        Sunday = 0b_0100_0000,
        Weekend = Saturday | Sunday
    }
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
}
