using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.HotelServices
{
    public interface IHotelService
    {
        Task AgregarHotelAsync(Hotel hotel);
        Task<List<Hotel>> HotelesDisponibles(DateTime fecahInicio, DateTime fechaFin);
        Task<List<Reserva>> TotalReservasMesHotel(Guid Id, int mes);
    }
}
