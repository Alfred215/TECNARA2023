using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExThreads.EjCajeros
{
    public class Cajero
    {
        public string Nombre { get; set; }
        public TipoCajeroEnum TipoCajero { get; set; }
        public EstadoCajeroEnum Estado { get; set; }

        public void AtenderCliente()
        {
            switch (TipoCajero)
            {
                case TipoCajeroEnum.Normal:
                    //System.Threading.Thread.Sleep(1000);
                    Thread.Sleep(100); // tiempo de espera de 1 segundo
                    break;
                case TipoCajeroEnum.VIP:
                    Thread.Sleep(50); // tiempo de espera de medio segundo
                    break;
                case TipoCajeroEnum.Express:
                    Thread.Sleep(75); // tiempo de espera de 0.75 segundos
                    break;
                default:
                    throw new Exception("Tipo de cajero desconocido");
            }
            Estado = EstadoCajeroEnum.Disponible;
        }
    }

    public enum TipoCajeroEnum
    {
        Normal,
        VIP,
        Express
    }

    public enum EstadoCajeroEnum
    {
        Disponible,
        Ocupado,
        EnDescanso
    }
}
