using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD.Entities;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio6_BBDD;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Entities;
using BBDD.PruebaBBDD;
using BBDD.PruebaBBDD.Entities;
using Ejercicios.BBDD.Ejercicios.Ejercicio1_BBDD;
using Ejercicios.BBDD.Ejercicios.Ejercicio2_BBDD;
using Ejercicios.BBDD.Ejercicios.Entidades;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Entidades;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;

namespace BBDD
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Métodos de Prueba
            //using (dbContextPrueba db = new dbContextPrueba())
            //{

            //    var persona1 = new Persona()
            //    {
            //        Id = 0,
            //        Name = "Alfredo",
            //        Surname1 = "Perez",
            //        Surname2 = "Gracia",
            //        Age = 22
            //    };

            //    var persona2 = new Persona()
            //    {
            //        Id = 5,
            //        Name = "Francisco",
            //        Surname1 = "Perez",
            //        Surname2 = "Gracia",
            //        Age = 22
            //    };

            //    #region Expresión larga
            //    //new Prueba(db).AddPersonAsync();
            //    //new Prueba(db).EditPerson(persona2); 
            //    #endregion

            //    #region Expresión Corta
            //    //new Prueba(db).AddEditAsync(persona2);
            //    #endregion

            //    #region DELETE 
            //    //new Prueba(db).DeletePersona(8); 
            //    #endregion

            //    #region GET LIST
            //    int i = 0;
            //    foreach (var persona in new Prueba(db).GetListPersona())
            //    {

            //        Console.WriteLine("{0} {1} {2} {3} {4}", ++i, persona.Name, persona.Surname1, persona.Surname2, persona.Age);
            //    }
            //    #endregion

            //    #region DELETE NEW
            //    //var listPersona = new Prueba(db).GetListPersona();

            //    //Console.WriteLine("Que persona quieres eliminar?");

            //    //var posicion = Convert.ToInt32(Console.ReadLine());
            //    //var id = listPersona[posicion - 1].Id;

            //    //new Prueba(db).DeletePersona(id);
            //    #endregion

            //    #region EDIT NEW
            //    //var listPersona2 = new Prueba(db).GetListPersona();

            //    //Persona personaEdit = new Persona();
            //    //Console.WriteLine("Que persona quieres editar?");
            //    //personaEdit.Id = listPersona2[Convert.ToInt32(Console.ReadLine()) - 1].Id;

            //    //Console.WriteLine("Nombre");
            //    //personaEdit.Name = Console.ReadLine();

            //    //Console.WriteLine("P. Apellido");
            //    //personaEdit.Surname1 = Console.ReadLine();

            //    //Console.WriteLine("S. Apellido");
            //    //personaEdit.Surname2 = Console.ReadLine();

            //    //Console.WriteLine("Edad");
            //    //personaEdit.Age = Convert.ToInt32(Console.ReadLine());

            //    //new Prueba(db).AddEditAsync(personaEdit);
            //    #endregion
            //}
            #endregion

            using (var dbEjercicios = new dbContextEjercicios())
            {
                new DB_EmpresaController(dbEjercicios);
                //new DB_CienteEmpleadoController(dbEjercicios);

            }

            using (var dbEjercicio3 = new dbContextEjerciciosRelaciones())
            {
                //await new Ejercicio3_BBDD(dbEjercicio3).BucleAsync();
            }

            using (var dbEjercicio5 = new dbContextEjercicio5())
            {
                await new Ejercicio5_Main(dbEjercicio5).MenuAsync();
            }

            using (var dbEjercicio6 = new dbContextEjerciciosRelaciones6())
            {
                await new Ejercicio6_Main(dbEjercicio6).MenuAsync();
            }
        }
    }
}
