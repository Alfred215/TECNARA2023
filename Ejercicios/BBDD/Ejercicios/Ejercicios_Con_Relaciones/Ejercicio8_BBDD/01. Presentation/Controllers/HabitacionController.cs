using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.HabitacionService;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._02._Services.HotelServices;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio8_BBDD._01._Presentation.Controllers
{
    public class HabitacionController
    {
        HabitacionService habitacionSV;
        public HabitacionController(dbContextEj8 db)
        {
            habitacionSV = new HabitacionService(db);
        }

        public async Task AgregarHabitacion(Habitacion habitacion)
        {
            await habitacionSV.AgregarHabitacion(habitacion);
        }

        public async Task TotalOcupacionHabitacionesHotel(Guid id, int año)
        {
            var result = await habitacionSV.TotalOcupacionHabitacionesHotel(id, año);
            Console.WriteLine("Dias totales reservado: {0}",result);
        }
    }
}
