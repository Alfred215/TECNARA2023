using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Juegos.TresEnRaya
{
    public class IniciarBoard
    {
        public List<Board> Iniciar(List<Board> board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board.Add(new Board { Rows = i, Columns = j, Value = ' ' });
                }
            }
            return board;
        }
    }
}
