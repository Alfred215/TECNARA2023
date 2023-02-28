using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.OOP.TresEnRaya
{
    public class Player
    {
        public List<Board> Move(List<Board> board, int currentPlayer)
        {
            int row, column;
            bool empty = false;
            
            Console.WriteLine("Jugador " + currentPlayer + ", elige una fila (1-3):");
            row = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Jugador " + currentPlayer + ", elige una columna (1-3):");
            column = int.Parse(Console.ReadLine()) - 1;

            foreach(var RowColumn in board)
            {
                if(RowColumn.Rows == row && RowColumn.Columns == column && char.IsWhiteSpace(RowColumn.Value))
                {
                    empty= true;
                    if (currentPlayer == 1)
                    {
                        RowColumn.Value = 'X';
                    }
                    else
                    {
                        RowColumn.Value = 'O';
                    }
                }
            }

            if (!empty)
            {
                Move(board, currentPlayer);
            }

            return board;
        }

        public int SwitchPlayer(int currentPlayer)
        {
            if (currentPlayer == 1)
            {
                currentPlayer = 2;
            }
            else
            {
                currentPlayer = 1;
            }

            return currentPlayer;
        }
    }
}
