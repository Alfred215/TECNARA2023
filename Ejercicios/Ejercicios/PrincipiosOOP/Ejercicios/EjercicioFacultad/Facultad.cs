﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Ejercicios.EjercicioFacultad
{
    public class Facultad
    {
        public void Ejercicio()
        {
            #region Estudiante
            Estudiante estudiante = new Estudiante("Pedro", "Perez", "12345678Z", "Soltero", "Informatica");

            Console.WriteLine("Estudiante: ");
            estudiante.ImprimirInformacion();
            estudiante.CambiarEstadoCivil("Casado");
            estudiante.MatricularEnCurso("Administración");

            Console.WriteLine("\nEstudiante modificado:");
            estudiante.ImprimirInformacion();
            #endregion

            #region Profesor
            Profesor profesor = new Profesor("Paco", "García", "12345678Z", "Casado", 2021, "1","Informatica");
            Console.WriteLine("\n Profesor:");
            profesor.ImprimirInformacion();

            profesor.ReasignarDespacho("3");
            profesor.CambiarDepartamento("Mates");

            Console.WriteLine("\nProfesor modificado:");
            profesor.ImprimirInformacion();
            #endregion

            #region PersonalServicio
            PersonalServicio personalServicio = new PersonalServicio("Paco", "García", "12345678Z", "Casado", 2021, "50", "Biblioteca");
            Console.WriteLine("\nPersonalServicio:");
            personalServicio.ImprimirInformacion();

            personalServicio.ReasignarDespacho("200");
            personalServicio.TrasladarSeccion("Comedor");

            Console.WriteLine("\nPersonalServicio modificado:");
            personalServicio.ImprimirInformacion();
            #endregion
        }
    }
}
