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
using Ejercicios.PrincipiosOOP.Abstraccion;
using Ejercicios.PrincipiosOOP.Polimorfismo2;
using Ejercicios.Juegos.Ahorcado;
using Ejercicios.PrincipiosOOP.Ejercicios.EjercicioFacultad;
using Ejercicios.PrincipiosOOP.Ejercicios.EjercicioVehiculo;
using Ejercicios.PrincipiosOOP.Ejercicios.EjercicioEmpresaDeportes;
using Ejercicios.Juegos.TresEnRaya;
using Ejercicios.Juegos.JuegoOca;
using Ejercicios.Juegos.RueletaDeLaSuerte;
using Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Pago;
using Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Garaje;
using Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_TiendaAnimal;
using Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Monedas;
using Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Paquetes;
using Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EjHerencia_Robots;
using Ejercicios.PrincipiosOOP.Ejercicios.Herencias.EJHerenciaYPoliformismo_Empresa;
using Ejercicios.EjemploClase.EjemploNulos;
using Ejercicios.LenguajeAvanzado.ExFicheros.LeerYCalcularMedia;
using Ejercicios.LenguajeAvanzado.ExFicheros.Agenda;
using Ejercicios.LenguajeAvanzado.ExLinq.ExMetodo;
using Ejercicios.LenguajeAvanzado.ExLinq.ExConsulta;
using Ejercicios.LenguajeAvanzado.ExRegex;
using Ejercicios.LenguajeAvanzado.ExFicheros;
using Ejercicios.LenguajeAvanzado.ExFicheros.GeneradorContrasena;
using Ejercicios.LenguajeAvanzado.ExFicheros.TrivialJuego;

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

            //EjercicioEmpleado ejercicioEmpleado = new EjercicioEmpleado();
            //ejercicioEmpleado.Ejercicio();

            //new Nulos().ej();

            //new ExplicacionEnum2();

            //new ExplicacionEnum().Explain();

            //new EjProducto2().EjercicioDeEjemplo();
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


            #endregion

            #region Ejercicios repaso Herencia
            //new EjGaraje().EjercicioGaraje();

            //new EjPago().EjercicioPago(); 

            //new EjMascotas();

            //new EjMonedas();

            //new EjEnvioPaquetes().EjercicioEnvioPaquetes();

            //new EjPeleaRobots().CombateRobot();

            //new EjercicioEmpleado().Ejercicio();
            #endregion

            #region Ejercicios de Herencia y Poliformismo
            //Facultad facultad = new Facultad();
            //facultad.Ejercicio();

            //AlquilarVehiculo alquilarVehiculo = new AlquilarVehiculo();
            //alquilarVehiculo.Ejercicio();

            //EmpresaDeportes empresaDeportes = new EmpresaDeportes();
            //empresaDeportes.Ejercicio();
            #endregion

            #region Juegos
            //new Ahorcado().gameAhorcado();

            //TresEnRaya treEnRaya = new TresEnRaya();
            //treEnRaya.Iniciar();

            //OcaGame oca = new OcaGame();
            //oca.Ejercutar();

            //Juego rulertaSuerte = new Juego();
            #endregion

            #region ex ENUMS
            //new EjPlaneta().EjCalcularTempPlaneta();
            //new EjEquipoFutbol().EjEquipos();
            //new EjCajero().TiempoCajero();
            //new EjFileEnums().MenuFile();

            #endregion

            #region ex DATETIME
            //new EjEvento();
            //new EjReserva();
            //new EjDiasLaborales();
            //new EjReunion();
            #endregion

            #region ex THREADS
            //new EjSuma();
            //new EjCarrera();
            #endregion

            #region ex FILES
            //new ExTheory();
            new ExRepasoFicheros();
            //new CalcularMedia();
            //new EjTaskManager();
            //new PasswordGenerator();
            //new Trivial();
            #endregion

            #region ex LINQ
            //new ExEstadisticas();
            //new ExConsultaPersonasBD(); 
            #endregion

            #region ex REGEX
            //new TheoryRegex();
            //new RegexContraseña();
            //new RegexCorreo();
            #endregion
        }
    }
}
