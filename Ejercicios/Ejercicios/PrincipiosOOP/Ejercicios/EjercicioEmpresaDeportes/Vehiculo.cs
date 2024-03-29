﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes
{
    public abstract class Vehiculo
    {
        private int CodigoVehiculo { get ; set; }
        private string Nombre { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }
        private int Plazas { get; set; }
        private string Color { get; set; }
        private string Marca { get; set; }
        private bool Encendido { get; set; }
        private bool Averiado { get; set; }

        public Vehiculo(string nombre, double peso, double altura, int plazas, string color, string marca)
        {
            CodigoVehiculo++;
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Plazas = plazas;
            Color = color;
            Marca = marca;
        }

        public abstract void DimeTipoAveria();

        public abstract void DimeVelocidad();
    }
}
