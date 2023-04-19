using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.HotelServices;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._01._Presentation.Controllers
{
    public class HotelController
    {
        HotelService hotelSV;
        public HotelController(dbContextEj8 db) 
        {
            hotelSV = new HotelService(db);
        }

        public async Task AgregarHotel(Hotel hotel)
        {
            await hotelSV.AgregarHotelAsync(hotel);
        }

        public async Task HotelesDisponibles(DateTime fecahInicio, DateTime fechaFin)
        {
            var result = await hotelSV.HotelesDisponibles(fecahInicio, fechaFin);
            foreach(var hotel in result)
            {
                Console.WriteLine("Nombre: {0} Dirección: {1} Estrellas: {2}", hotel.Nombre, hotel.Direccion, hotel.Estrellas);
            }
        }

        public async Task TotalReservasMesHotel(Guid id, int mes)
        {
            var result = await hotelSV.TotalReservasMesHotel(id, mes);
            foreach (var reserva in result)
            {
                Console.WriteLine("Reservas fecha inicio: {0} - fecha fin:{1}", reserva.FechaInicio, reserva.FechaFin);
            }
        }
    }
}
