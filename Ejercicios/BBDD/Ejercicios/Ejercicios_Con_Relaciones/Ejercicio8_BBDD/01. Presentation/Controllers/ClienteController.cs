using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.ClienteService;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.HabitacionService;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._01._Presentation.Controllers
{
    public class ClienteController
    {
        ClienteService clienteSV;
        public ClienteController(dbContextEj8 db)
        {
            clienteSV = new ClienteService(db);
        }

        public async Task AgregarCliente(Cliente cliente)
        {
            await clienteSV.AgregarCliente(cliente);
        }

        public async Task TotalOcupacionHabitacionesHotel(Guid id)
        {
            var result = await clienteSV.TotalReservasCliente(id);
            foreach (var reserva in result)
            {
                Console.WriteLine("IdReserva: {0} IdHabitacion: {1} Fecha Inicio: {2} Fecha Fin: {3}", reserva.IdReserva, reserva.IdHabitacion, reserva.FechaInicio, reserva.FechaFin);
            }
        }
    }
}
