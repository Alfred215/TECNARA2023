using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.TresEnRaya
{
    public class ImprimirBoard
    {
        public void Imprimir(List<Board> board)
        {


            Console.WriteLine(" ");
            Console.WriteLine(" " + board[0].Value + " | " + board[1].Value + " | " + board[2].Value + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + board[3].Value + " | " + board[4].Value + " | " + board[5].Value + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + board[6].Value + " | " + board[7].Value + " | " + board[8].Value + " ");
            Console.WriteLine(" ");
        }
    }
}
