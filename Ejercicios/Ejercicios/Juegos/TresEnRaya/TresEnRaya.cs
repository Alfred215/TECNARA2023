using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.TresEnRaya
{
    public class TresEnRaya
    {
        static int currentPlayer = 1; //Jugador 1 o 2

        public void Iniciar()
        {
            List<Board> board = new List<Board>();

            IniciarBoard initializeBoard = new IniciarBoard();
            board = initializeBoard.Iniciar(board);

            ImprimirBoard printBoard = new ImprimirBoard();


            Player player = new Player();
            CheckWinner check = new CheckWinner();

            while (!check.Winner(board))
            {
                board = player.Move(board, currentPlayer);
                printBoard.Imprimir(board);
                if (!check.Winner(board))
                {
                    currentPlayer = player.SwitchPlayer(currentPlayer);
                }
            }

            Console.WriteLine("¡Jugador " + currentPlayer + " ha ganado!");
            Console.ReadLine();
        }
    }
}
