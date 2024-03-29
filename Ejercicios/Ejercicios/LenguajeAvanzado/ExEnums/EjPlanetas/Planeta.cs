﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExEnums.EjPlanetas
{
    public class Planeta
    {
        public string Nombre { get; set; }
        public double DistanciaSol { get; set; }
        public TipoAtmosferaPlaneta TipoAtmosfera { get; set; }

        public double CalcularTemperatura()
        {
            double temperatura = 0;

            switch (TipoAtmosfera)
            {
                case TipoAtmosferaPlaneta.SinAtmosfera:
                    temperatura = -270;
                    break;
                case TipoAtmosferaPlaneta.AtmosferaRespirable:
                    if (DistanciaSol < 150000000)
                    {
                        temperatura = 15;
                    }
                    else
                    {
                        temperatura = 5;
                    }
                    break;
                case TipoAtmosferaPlaneta.AtmosferaNoRespirable:
                    if (DistanciaSol < 100000000)
                    {
                        temperatura = 50;
                    }
                    else
                    {
                        temperatura = 20;
                    }
                    break;
                default:
                    break;
            }

            return temperatura;
        }
    }

    public enum TipoAtmosferaPlaneta
    {
        SinAtmosfera,
        AtmosferaRespirable,
        AtmosferaNoRespirable
    }
}
