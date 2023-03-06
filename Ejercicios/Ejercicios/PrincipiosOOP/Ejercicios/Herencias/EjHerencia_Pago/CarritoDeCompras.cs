using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Pago
{
    public class CarritoDeCompras
    {
        private List<string> productos;
        private MetodoDePago metodoDePago;

        public CarritoDeCompras()
        {
            productos = new List<string>();
        }

        public void AgregarProducto(string producto)
        {
            productos.Add(producto);
        }

        public void SeleccionarMetodoDePago(MetodoDePago metodoDePago)
        {
            this.metodoDePago = metodoDePago;
        }

        public void ProcesarPago(double monto)
        {
            metodoDePago.RealizarPago(monto);
        }
    }
}
