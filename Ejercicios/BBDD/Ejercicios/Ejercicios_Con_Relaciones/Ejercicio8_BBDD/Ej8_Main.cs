using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._01._Presentation.Controllers;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD
{
    public class Ej8_Main
    {
        HotelController hotel;
        public Ej8_Main(dbContextEj8 db) 
        {
            hotel= new HotelController(db);
        }

        public async void AgregarHotel()
        {
            await hotel.AgregarHotel(new Hotel());
        }

        public async void Disponibilidad()
        {
            var fechaInicio = new DateTime(2023, 02, 22);
            var fechaFin = new DateTime(2023, 04, 26);

            await hotel.HotelesDisponibles(fechaInicio, fechaFin);
        }

        public async void ReservasMes()
        {
            int mes = 3;
            Guid id = Guid.Parse("CAFD90EA-C80E-4359-9E97-0735C22D12CC");

            await hotel.TotalReservasMesHotel(id, mes);
        }
    }
}
