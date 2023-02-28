using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicios.EjemploClase.Ejemplo_polimorfirsmo.Entidades;

namespace Ejercicios.EjemploClase.Ejemplo_polimorfirsmo
{
    internal class Ejercicio
    {
        #region Listas
        public List<InfoDepTecnologia> jefesEquipo = new List<InfoDepTecnologia>();
        public List<InfoDepTecnologia> tecnicos = new List<InfoDepTecnologia>();
        public List<InfoDepVentas> jefesVentas = new List<InfoDepVentas>();
        public List<InfoDepVentas> comerciales = new List<InfoDepVentas>();
        public List<InfoDireccion> dptoDireccion = new List<InfoDireccion>();

        #endregion
        public void GestiónTrabajadores()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1-Alta de jefes de equipo.");
                Console.WriteLine("2-Alta de técnicos (comprobar que el responsable existe)");
                Console.WriteLine("3-Alta de jefes de ventas.");
                Console.WriteLine("4-Alta de Comerciales (comprobar que el responsable existe).");
                Console.WriteLine("5-Alta de personas de dpto. de dirección.");
                Console.WriteLine("6-Mostrar todos los técnicos.");
                Console.WriteLine("7-Mostrar los técnicos según responsable.");
                Console.WriteLine("8-Mostrar los comerciales según responsable.");
                Console.WriteLine("9-Mostrar jefes de equipo según tecnología.");
                Console.WriteLine("10-Mostrar Dpto. Dirección.");
                Console.WriteLine("11-Baja de personal.");
                Console.WriteLine("12-Salir.");
                Console.WriteLine("Seleccione una opción:");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            AltaJefesEquipo();
                            break;
                        case 2:
                            AltaTecnicos();
                            break;
                        case 3:
                            AltaJefesVentas();
                            break;
                        case 4:
                            AltaComerciales();
                            break;
                        case 5:
                            AltaDptoDireccion();
                            break;
                        case 6:
                            MostrarTecnicos();
                            break;
                        case 7:
                            MostrarTecnicosPorResponsable();
                            break;
                        case 8:
                            MostrarComercialesPorResponsable();
                            break;
                        case 9:
                            MostrarJefesEquipoPorTecnologia();
                            break;
                        case 10:
                            MostrarDptoDireccion(Console.ReadLine());
                            break;
                        case 11:
                            BajaPersonal(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 12:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                Console.WriteLine();
            } while (opcion != 12);
        }

        public void AltaJefesEquipo()
        {
            //Console.WriteLine("Introduzca el DNI del jefe de equipo:");
            //string dni = Console.ReadLine();
            //Console.WriteLine("Introduzca el nombre del jefe de equipo:");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Introduzca los apellidos del jefe de equipo:");
            //string apellidos = Console.ReadLine();
            //Console.WriteLine("Introduzca la fecha de nacimiento del jefe de equipo (en formato dd/mm/aaaa):");
            //DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Introduzca la dirección del jefe de equipo:");
            //string direccion = Console.ReadLine();
            //Console.WriteLine("Introduzca la tecnología del jefe de equipo:");
            //string tecnologia = Console.ReadLine();
            //Console.WriteLine("Introduzca los años de experiencia del jefe de equipo:");
            //int anosExperiencia = int.Parse(Console.ReadLine());

            //InfoDepTecnologia jefeEquipo = new InfoDepTecnologia(dni, nombre, apellidos, fechaNacimiento, direccion, anosExperiencia, tecnologia);

            //jefesEquipo.Add(jefeEquipo);

            //Console.WriteLine("Jefe de equipo añadido con éxito.");
        }

        public void AltaTecnicos()
        {
            //Console.WriteLine("Introduzca el DNI del técnico:");
            //string dni = Console.ReadLine();
            //Console.WriteLine("Introduzca el nombre del técnico:");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Introduzca los apellidos del técnico:");
            //string apellidos = Console.ReadLine();
            //Console.WriteLine("Introduzca la fecha de nacimiento del técnico (en formato dd/mm/aaaa):");
            //DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Introduzca la dirección del técnico:");
            //string direccion = Console.ReadLine();
            //Console.WriteLine("Introduzca la tecnología del técnico:");
            //string tecnologia = Console.ReadLine();
            //Console.WriteLine("Introduzca el DNI del responsable del técnico:");
            //string dniResponsable = Console.ReadLine();

            //InfoDepTecnologia responsable = jefesEquipo.Find(jefeEquipo => jefeEquipo.DNI == dniResponsable);

            //if (responsable != null)
            //{
            //    InfoDepTecnologia tecnico = new InfoDepTecnologia(dni, nombre, apellidos, fechaNacimiento, direccion, 0, tecnologia);
            //    tecnicos.Add(tecnico);

            //    Console.WriteLine("Técnico añadido con éxito.");
            //}
            //else
            //{
            //    Console.WriteLine("No se encontró ningún jefe de equipo con el DNI indicado.");
            //}
        }

        private void AltaJefesVentas()
        {
            //Console.WriteLine("Alta de jefes de ventas.");

            //// Pedir los datos del nuevo trabajador
            //Console.Write("Introduzca el DNI del nuevo trabajador: ");
            //string dni = Console.ReadLine();
            //Console.Write("Introduzca el nombre del nuevo trabajador: ");
            //string nombre = Console.ReadLine();
            //Console.Write("Introduzca los apellidos del nuevo trabajador: ");
            //string apellidos = Console.ReadLine();
            //Console.Write("Introduzca la fecha de nacimiento del nuevo trabajador (en formato dd/mm/yyyy): ");
            //DateTime fechaNacimiento;
            //while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNacimiento))
            //{
            //    Console.WriteLine("Fecha inválida. Introduzca la fecha de nacimiento del nuevo trabajador (en formato dd/mm/yyyy): ");
            //}
            //Console.Write("Introduzca la dirección del nuevo trabajador: ");
            //string direccion = Console.ReadLine();
            //Console.Write("Introduzca la zona comercial del nuevo trabajador: ");
            //string zonaComercial = Console.ReadLine();

            //// Comprobar que hay al menos un jefe de equipo
            //if (jefesEquipo.Count == 0)
            //{
            //    Console.WriteLine("No hay jefes de equipo dados de alta. Debe dar de alta al menos un jefe de equipo antes de dar de alta un jefe de ventas.");
            //    return;
            //}

            //// Pedir el DNI del responsable del nuevo trabajador
            //Console.Write("Introduzca el DNI del jefe de equipo responsable del nuevo trabajador: ");
            //string dniResponsable = Console.ReadLine();

            //// Buscar el jefe de equipo responsable en la base de datos
            //InfoDepTecnologia responsable = null;
            //foreach (var jefeEquipo in jefesEquipo)
            //{
            //    if (jefeEquipo.DNI == dniResponsable)
            //    {
            //        responsable = jefeEquipo;
            //        break;
            //    }
            //}

            //// Si no se encuentra el responsable, mostrar mensaje de error y salir del método
            //if (responsable == null)
            //{
            //    Console.WriteLine("El jefe de equipo responsable no existe.");
            //    return;
            //}

            //// Crear el objeto de tipo InfoDepVentas y añadirlo a la lista de trabajadores de ventas
            //var nuevoTrabajador = new InfoDepVentas(dni, nombre, apellidos, fechaNacimiento, direccion, zonaComercial);
            //nuevoTrabajador.Responsable = responsable;
            //ventas.Add(nuevoTrabajador);

            //Console.WriteLine("Trabajador dado de alta con éxito.");
        }

        public void AltaComerciales()
        {
            //Console.WriteLine("Introduzca los siguientes datos del nuevo comercial:");
            //Console.Write("DNI: ");
            //string dni = Console.ReadLine();
            //Console.Write("Nombre: ");
            //string nombre = Console.ReadLine();
            //Console.Write("Apellidos: ");
            //string apellidos = Console.ReadLine();
            //Console.Write("Fecha de Nacimiento (yyyy-MM-dd): ");
            //DateTime fechaNacimiento;
            //if (!DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
            //{
            //    Console.WriteLine("Fecha inválida.");
            //    return;
            //}
            //Console.Write("Dirección: ");
            //string direccion = Console.ReadLine();
            //Console.Write("Zona comercial: ");
            //string zonaComercial = Console.ReadLine();
            //Console.Write("DNI del responsable: ");
            //string dniResponsable = Console.ReadLine();
            //InfoTrabajador responsable = BuscarTrabajadorPorDNI(dniResponsable);
            //if (responsable == null || !(responsable is InfoDepVentas))
            //{
            //    Console.WriteLine("El responsable no existe o no es del departamento de ventas.");
            //    return;
            //}

            //InfoDepVentas nuevoComercial = new InfoDepVentas(dni, nombre, apellidos, fechaNacimiento, direccion, zonaComercial);
            //((InfoDepVentas)responsable).Subordinados.Add(nuevoComercial);
            //Console.WriteLine("Comercial añadido correctamente.");

        }

        public void AltaDptoDireccion()
        {
            //Console.WriteLine("Introduzca los siguientes datos de la nueva persona del departamento de dirección:");
            //Console.Write("DNI: ");
            //string dni = Console.ReadLine();
            //Console.Write("Nombre: ");
            //string nombre = Console.ReadLine();
            //Console.Write("Apellidos: ");
            //string apellidos = Console.ReadLine();
            //Console.Write("Fecha de Nacimiento (yyyy-MM-dd): ");
            //DateTime fechaNacimiento;
            //if (!DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
            //{
            //    Console.WriteLine("Fecha inválida.");
            //    return;
            //}
            //Console.Write("Dirección: ");
            //string direccion = Console.ReadLine();
            //Console.Write("Cargo: ");
            //string cargo = Console.ReadLine();
            //InfoDireccion nuevaPersonaDireccion = new InfoDireccion(dni, nombre, apellidos, fechaNacimiento, direccion, cargo);
            //dptoDireccion.Personal.Add(nuevaPersonaDireccion);
            //Console.WriteLine("Persona del departamento de dirección añadida correctamente.");

        }

        public void MostrarTecnicos()
        {
            //Console.WriteLine("Listado de técnicos:");
            //foreach (var tecnico in ListaTecnicos)
            //{
            //    Console.WriteLine($"DNI: {tecnico.DNI} - Nombre: {tecnico.Nombre} {tecnico.Apellidos} - Fecha de nacimiento: {tecnico.FechaNacimiento:yyyy-MM-dd} - Dirección: {tecnico.Direccion} - Años de experiencia: {tecnico.AnosExperiencia} - Tecnología: {tecnico.Tecnologia}");
            //}
        }

        public void MostrarTecnicosPorResponsable()
        {
            //Console.Write("Introduzca el DNI del responsable: ");
            //string dniResponsable = Console.ReadLine(); InfoTrabajador responsable = BuscarTrabajadorPorDNI(dniResponsable);
            //if (responsable == null || !(responsable is InfoJefeEquipo))
            //{
            //    Console.WriteLine("El responsable no existe o no es un jefe de equipo.");
            //    return;
            //}

            //Console.WriteLine($"Listado de técnicos del responsable {responsable.Nombre} {responsable.Apellidos}:");
            //foreach (var tecnico in ((InfoJefeEquipo)responsable).Subordinados.OfType < InfoDepTecn
        }

        public void MostrarComercialesPorResponsable()
        {
            //Console.WriteLine("Introduce el DNI del responsable:");
            //string dniResponsable = Console.ReadLine();

            //// Buscamos al responsable en la lista de trabajadores
            //InfoTrabajador responsable = ListaTrabajadores.FirstOrDefault(t => t.DNI == dniResponsable);

            //if (responsable != null)
            //{
            //    // Si el responsable es de ventas, mostramos los comerciales que dependen de él
            //    if (responsable is InfoDepVentas)
            //    {
            //        List<InfoTrabajador> comercialesResponsable = ListaTrabajadores.Where(t => t is InfoComercial && ((InfoComercial)t).Responsable == dniResponsable).ToList();

            //        Console.WriteLine($"Comerciales que dependen del responsable {responsable.Nombre} {responsable.Apellidos}:");
            //        foreach (InfoComercial comercial in comercialesResponsable)
            //        {
            //            Console.WriteLine($"{comercial.Nombre} {comercial.Apellidos}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El trabajador con DNI {dniResponsable} no es un responsable de ventas.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"No se encontró ningún trabajador con DNI {dniResponsable}.");
            //}
        }

        public void MostrarJefesEquipoPorTecnologia()
        {
            //Console.WriteLine("Ingrese la tecnología:");
            //string tecnologia = Console.ReadLine();

            //Console.WriteLine("Jefes de equipo que manejan la tecnología '{0}':", tecnologia);

            //foreach (var jefe in jefesEquipo.Where(j => j.Tecnologia == tecnologia))
            //{
            //    Console.WriteLine("{0} {1}, DNI: {2}", jefe.Nombre, jefe.Apellidos, jefe.DNI);
            //}

            //Console.WriteLine();
        }

        public void MostrarDptoDireccion(string direccion)
        {
            //Console.WriteLine($"Comerciales en el departamento de {direccion}:");
            //foreach (var departamento in dptoDireccion)
            //{
            //    if (departamento.Direccion == direccion)
            //    {
            //        foreach (var comercial in departamento.Comerciales)
            //        {
            //            Console.WriteLine($"- {comercial.Nombre} ({departamento.Tecnologia})");
            //        }
            //    }
            //}
        }

        public void BajaPersonal(int dni)
        {
            //foreach (var empleado in empleados)
            //{
            //    if (empleado.Dni == dni)
            //    {
            //        if (empleado is Comercial)
            //        {
            //            var comercial = empleado as Comercial;
            //            var jefe = comercial.Jefe;
            //            jefe.Comerciales.Remove(comercial);
            //        }
            //        else if (empleado is JefeVentas)
            //        {
            //            var jefeVentas = empleado as JefeVentas;
            //            var responsable = jefeVentas.Responsable;
            //            responsable.JefeVentas = null;
            //        }
            //        else if (empleado is JefeEquipo)
            //        {
            //            var jefeEquipo = empleado as JefeEquipo;
            //            var tecnologia = jefeEquipo.Tecnologia;
            //            tecnologia.JefeEquipo = null;
            //        }
            //        else if (empleado is Director)
            //        {
            //            var director = empleado as Director;
            //            var dpto = director.Departamento;
            //            dpto.Director = null;
            //        }

            //        empleados.Remove(empleado);
            //        Console.WriteLine("Empleado con DNI " + dni + " dado de baja.");
            //        return;
            //    }
            //}

            //Console.WriteLine("Empleado con DNI " + dni + " no encontrado.");
        }

    }
}
