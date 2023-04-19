using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.HabitacionService;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.RoomService;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._01._Presentation.Controllers
{
    public class ReservaController
    {
        ReservaService reservaSV;
        public ReservaController(dbContextEj8 db)
        {
            reservaSV = new ReservaService(db);
        }

        public async Task RealizarReserva(Reserva reserva)
        {
            await reservaSV.RealizarReserva(reserva);
        }
        public async Task CancelarReserva(Reserva reserva)
        {
            await reservaSV.CancelarReserva(reserva.IdReserva);
        }

        public async Task TotalReservasMesHotel(DateTime fecahInicio, DateTime fechaFin)
        {
            var result = await reservaSV.ComprobarDisponibilidadReserva(fecahInicio, fechaFin);
            foreach (var hotel in result)
            {
                Console.WriteLine("Nombre: {0} Dirección: {1} Estrellas: {2}", hotel.Nombre, hotel.Direccion, hotel.Estrellas);
            }
        }
    }
}
