using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.OOP.TresEnRaya
{
    public class CheckWinner
    {
        public bool Winner(List<Board> board)
        {
            // Comprobar filas
            for (int i = 0; i < board.Count; i = i+3)
            {
                if (board[i].Value != ' ' && board[i].Value == board[i + 1].Value && board[i + 1].Value == board[i + 2].Value)
                {
                    return true;
                }
            }

            // Comprobar columnas
            for (int j = 0; j < 3; j++)
            {
                if (board[j].Value != ' ' && board[j].Value == board[j + 3].Value && board[j + 3].Value == board[j + 6].Value)
                {
                    return true;
                }
            }

            // Comprobar Diagonales

            if (board[0].Value != ' ' && board[0].Value == board[4].Value && board[4].Value == board[8].Value)
            {
                return true;
            }
            else if (board[2].Value != ' ' && board[2].Value == board[4].Value && board[4].Value == board[6].Value)
            {
                return true;
            }

            return false;
        }
    }
}
