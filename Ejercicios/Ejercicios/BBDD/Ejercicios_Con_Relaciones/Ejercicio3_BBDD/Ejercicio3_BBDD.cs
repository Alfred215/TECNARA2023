using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD
{
    public class Ejercicio3_BBDD
    {
        BankMethod bank;
        ClientMethod client;
        public Ejercicio3_BBDD(dbContextEjerciciosRelaciones db)
        {
            bank = new BankMethod(db);
            client = new ClientMethod(db);
        }


    }
}
