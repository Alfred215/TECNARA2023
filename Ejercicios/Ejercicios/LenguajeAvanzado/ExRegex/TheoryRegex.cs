 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExRegex
{
    internal class TheoryRegex
    {
        public TheoryRegex() {
            string reForNumbers = "^[0 - 9] +$";
            Regex reNumber = new Regex(reForNumbers);
            if (reNumber.IsMatch(Console.ReadLine()) == true) 
            { 
                /* el código que sea… */ 
            }

            string reForThreeNumbers = "^([0-9]+),([0-9]+),([0-9]+)$";
            Regex re = new Regex(reForThreeNumbers);
            Match matchFor3Nums = re.Match("12,34,56");
            if (matchFor3Nums.Success == true)
            {
                Console.WriteLine($"1º número: { matchFor3Nums.Groups[1].Value}");
                Console.WriteLine($"2º número: { matchFor3Nums.Groups[2].Value}");
                Console.WriteLine($"3º número: { matchFor3Nums.Groups[3].Value}");
            }
        }
    }
}
