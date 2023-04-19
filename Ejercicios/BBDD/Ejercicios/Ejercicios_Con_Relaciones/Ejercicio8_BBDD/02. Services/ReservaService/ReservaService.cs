using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.RoomService
{
    public class ReservaService : IReservaService
    {
        dbContextEj8 db;

        public ReservaService(dbContextEj8 _db)
        {
            db = _db;
        }
        public async Task RealizarReserva(Reserva reserva)
        {
            await db.AddAsync(reserva);
            db.SaveChanges();
        }

        public async Task CancelarReserva(Guid id)
        {
            var resultOld = await db.Reserva.Where(x => x.IdReserva == id).FirstOrDefaultAsync();
            db.Reserva.Remove(resultOld);
            db.SaveChanges();
        }

        public async Task<List<Hotel>> ComprobarDisponibilidadReserva(DateTime fecahInicio, DateTime fechaFin)
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
            return await query.ToListAsync();
        }

        
    }
}
