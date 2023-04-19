using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.HabitacionService
{
    public class HabitacionService : IHabitacionService
    {
        dbContextEj8 db;

        public HabitacionService(dbContextEj8 _db)
        {
            db = _db;
        }

        public async Task AgregarHabitacion(Habitacion habitacion)
        {
            await db.AddAsync(habitacion);
            db.SaveChanges();
        }

        public async Task<double> TotalOcupacionHabitacionesHotel(Guid hotelId, int año)
        {
            var query = from hotel in db.Hotel
                        where hotelId == hotel.IdHotel
                        from habitacion in db.Habitacion
                        where hotel.IdHotel == habitacion.IdHotel
                        from reserva in db.Reserva
                        where reserva.IdHabitacion == habitacion.IdHabitacion && reserva.FechaInicio.Year == año && reserva.FechaFin.Year == año
                        select new
                        {
                            Habitacion = habitacion,
                            TotalDias = (reserva.FechaFin - reserva.FechaInicio).TotalDays
                        };

            return query.Select(x=> x.TotalDias).ToList().Sum();
        }
    }
}
