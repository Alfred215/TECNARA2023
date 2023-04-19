using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.RoomService
{
    public interface IReservaService
    {
        Task RealizarReserva(Reserva reserva);
        Task CancelarReserva(Guid id);
        Task<List<Hotel>> ComprobarDisponibilidadReserva(DateTime fecahInicio, DateTime fechaFin);
    }
}
