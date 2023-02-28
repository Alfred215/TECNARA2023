using Ejercicios.OOP.Ejercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.OOP.Ejercicio1
{
    public class CuentaBancaria
    {
        private string NombreCuetna { get; set; }

        private string NumCuenta { get; set; }
        private decimal Saldo { get; set; }

        private List<IngresosRetiradas> IngresosRetiradas = new List<IngresosRetiradas>();

        public CuentaBancaria(string nombreCuenta, string numCuenta, decimal saldo)
        {
            NombreCuetna= nombreCuenta;
            NumCuenta = numCuenta;
            Saldo = saldo;
        }

        public void IngrearDinero(decimal ingreso)
        {
            Saldo = Saldo + ingreso;
            IngresosRetiradas.Add(new IngresosRetiradas { Ingreso = ingreso });
        }

        public void RetirarDinero(decimal retirar)
        {
            if(Saldo > retirar)
            {
                Saldo = Saldo - retirar;
                IngresosRetiradas.Add(new IngresosRetiradas { Retirada = retirar });
            }
            else
            {
                Console.WriteLine("El saldo es inferior a la retirada.");
            }
            
        }

        public decimal VerSaldo()
        {
            return Saldo;
        }

        public List<IngresosRetiradas> TodosMovimientos()
        {
            return IngresosRetiradas;
        }

        public List<decimal> TodosIngresos()
        {
            List<decimal> list = new List<decimal>();
            foreach(var ingresos in IngresosRetiradas)
            {
                if (ingresos.Ingreso.HasValue)
                {
                    list.Add((decimal)ingresos.Ingreso);
                }
            }
            return list;
        }

        public List<decimal> TodosRetiradas()
        {
            List<decimal> list = new List<decimal>();
            foreach (var ingresos in IngresosRetiradas)
            {
                if (ingresos.Retirada.HasValue)
                {
                    list.Add((decimal)ingresos.Retirada);
                }
            }
            return list;
        }
    }
}
