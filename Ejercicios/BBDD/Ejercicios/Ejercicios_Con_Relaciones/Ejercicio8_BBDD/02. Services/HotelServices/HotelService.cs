using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.HotelServices
{
    public class HotelService : IHotelService
    {
        dbContextEj8 db;

        public HotelService(dbContextEj8 _db)
        {
            db = _db;
        }

        public async Task AgregarHotelAsync(Hotel hotel)
        {
            await db.AddAsync(hotel);
            db.SaveChanges();
        }

        public async Task<List<Hotel>> HotelesDisponibles(DateTime fecahInicio, DateTime fechaFin)
        {
            var query = (
                        from h0 in db.Hotel
                        join h in db.Habitacion on h0.IdHotel equals h.IdHotel
                        where !db.Reserva.Any(r => r.IdHabitacion == h.IdHabitacion &&
                                                (r.FechaInicio <= fecahInicio && r.FechaFin >= fecahInicio ||
                                                r.FechaInicio <= fechaFin && r.FechaFin >= fechaFin)
                                            )
                        select h0
                ).Distinct();
            return query.ToList();
        }

        public async Task<List<Reserva>> TotalReservasMesHotel(Guid Id, int mes)
        {
            var query = 
                        from r in db.Reserva
                        from h in db.Habitacion.Where(x => x.IdHabitacion == r.IdHabitacion)
                        where h.IdHotel == Id && r.FechaInicio.Month == mes && r.FechaFin.Month == mes
                        select r;

            return query.ToList();
        }
    }
}
