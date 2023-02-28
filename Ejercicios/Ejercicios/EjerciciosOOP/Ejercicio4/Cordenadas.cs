using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.OOP.Ejercicio4
{
    public class CoordenadasObj
    {
        public int Id { get; set; }
        public decimal EjeX { get; set; }
        public decimal EjeY { get; set;}
    }

    public class CoordenadasEvent
    {
        List<CoordenadasObj> coordenadas = new List<CoordenadasObj>();

        //Nuema cordenada
        public void NewCoordenada(int id, decimal ejeX, decimal ejeY)
        {
            coordenadas.Add(new CoordenadasObj { Id = id, EjeX = ejeX, EjeY = ejeY });
        }

        //Coger cordenadas
        public List<CoordenadasObj> GetCoordenadas()
        {
            return coordenadas;
        }

        //Coger una cordenada
        public CoordenadasObj GetCoordenada(int id)
        {
            return coordenadas.Where(x => x.Id == id).FirstOrDefault();
        }

        //Editar cordenada
        public void EditCoordenada(int id, decimal ejeX, decimal ejeY)
        {
            var position = Array.IndexOf(coordenadas.Select(x => x.Id).ToArray(),id);

            coordenadas[position].EjeX = ejeX;
            coordenadas[position].EjeY = ejeY;

        }

        //Comprobar distancia entre dos cordenadas
        public (decimal,decimal) GetDistancia(int cordId_1, int cordId_2)
        {
            var cord_1 = coordenadas.Where(x => x.Id == cordId_1).FirstOrDefault();
            var cord_2 = coordenadas.Where(x => x.Id == cordId_2).FirstOrDefault();

            var distanciaX = cord_1.EjeX - cord_2.EjeX;
            var distanciaY = cord_1.EjeY - cord_2.EjeY;

            return (distanciaX < 0 ? distanciaX * -1 : distanciaX, distanciaY < 0 ? distanciaY * -1 : distanciaY);
        }
    }
}
