using System.Drawing;
using System;
using System.Text.RegularExpressions;
using Ejercicios.OOP.Ejercicio1;
using Ejercicios.OOP.Ejercicio2;
using Ejercicios.OOP.Ejercicio3;
using Ejercicios.OOP.Ejercicio4;
using Ejercicios.EjemploClase.Ejemplo1;
using Ejercicios.EjemploClase.ListaDeContactos;
using Ejercicios.EjemploClase.Ejemplo_Static;
using Ejercicios.EjemploClase.Ejemplo_Static_Id;
using Ejercicios.EjemploClase.GestionBiblioteca;
using Ejercicios.EjemploClase.Ejemplo_Herencia;
using Ejercicios.PrincipiosOOP.Abstraccion;
using Ejercicios.PrincipiosOOP.Polimorfismo2;
using Ejercicios.Juegos.Ahorcado;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios ejercicios = new Ejercicios();
            //ejercicios.LlamarEjercicios();

            #region Ejemplos de Clases y objetos
            //Ejemplo_Persona ejemplo1 = new Ejemplo_Persona();
            //ejemplo1.Ejercicio();
            //new Ejemplo_Persona().Ejercicio();

            //EjemploContactos ejemploContactos = new EjemploContactos();
            //ejemploContactos.Ejercicio();
            //new EjemploContactos().Ejercicio();

            //Ejemplo_Static e = new Ejemplo_Static();
            //e.ComprobarStatic();
            //new Ejemplo_Static().ComprobarStatic();

            //ListaPersonas l = new ListaPersonas();
            //l.AñadirYVerPersonas();
            //new ListaPersonas().AñadirYVerPersonas();

            //GestionarBiblioteca g = new GestionarBiblioteca();
            //g.Gestion();
            //new GestionarBiblioteca().Gestion();

            //new EjercicioHerenciaTrabajador().EjercicioHerenciaTrabajadorCode();

            //new EjercicioAbstraccion();

            //new EjemploPolimorfismo().MetodoPrincipal();
            #endregion

            #region Ejercicios de Clases y objetos

            //new Ejercicio1().Ejercicio();

            //Ejercicio1 ejercicio1 = new Ejercicio1();
            //ejercicio1.Ejercicio();

            //Ejercicio2 ejercicio2 = new Ejercicio2();
            //ejercicio2.Ejercicio();

            //Ejercicio3 ejercicio3 = new Ejercicio3();
            //ejercicio3.Ejercicio();

            //Ejercicio4 ejercicio4 = new Ejercicio4();
            //ejercicio4.Ejercicio();

            //TresEnRaya treEnRaya = new TresEnRaya();
            //treEnRaya.Iniciar();
            #endregion

            new Ahorcado().gameAhorcado();
        }


    }
}
