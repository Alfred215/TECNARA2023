using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.ClienteService
{
    public interface IClienteService
    {
        Task AgregarCliente(Cliente cliente);
        Task<List<Reserva>> TotalReservasCliente(Guid clienteId);
    }
}
