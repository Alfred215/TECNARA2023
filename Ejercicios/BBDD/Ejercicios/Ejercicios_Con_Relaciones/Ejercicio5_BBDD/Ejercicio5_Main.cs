using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD.Entities;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Controllers;
using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio6_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio5_BBDD
{
    public class Ejercicio5_Main
    {
        CentroService centroService;
        AlumnoService alumnoService;
        ProfesorService profesorService;
        CursoService cursoService;
        AsignaturaService asignaturaService;

        public Ejercicio5_Main(dbContextEjercicio5 _db)
        {
            centroService = new CentroService(_db);
            alumnoService = new AlumnoService(_db);
            profesorService = new ProfesorService(_db);
            cursoService = new CursoService(_db);
            asignaturaService = new AsignaturaService(_db);
        }

        public async Task MenuAsync()
        {
            do
            {
                Console.WriteLine("1-Centro \n2-Alumno \n3-Profesor \n4-Curso \n5-Asignatura");
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    #region Centro
                    case 1:
                        Console.WriteLine("1-Crear o Editar \n2-Listar \n3-Obtener Centro con más Alumnos \n4-Obtener Centro con más Profesores \n5-Suma de horas de todos los cursos de un centro \n6-Eliminar");
                        var optionCentro = int.Parse(Console.ReadLine());

                        switch (optionCentro)
                        {
                            case 1:
                                await centroService.AddEditAsync(await CreateOrEditCentroAsync());
                                break;
                            case 2:
                                await centroService.GetListAsync();
                                break;
                            case 3:
                                var centroMaxAlumno = await centroService.GetListMaxAlumnosCenterAsync();

                                Console.WriteLine("Centro con más alumnos: {0}", centroMaxAlumno.Nombre);
                                break;
                            case 4:
                                var centroMaxProfesor = await centroService.GetListMaxProfesorCenterAsync();

                                Console.WriteLine("Centro con más profesores: {0}", centroMaxProfesor.Nombre);
                                break;
                            case 5:
                                var listCentros = await centroService.GetListAsync();
                                Console.WriteLine("Elija una posición");
                                var positionCentro = Convert.ToInt32(Console.ReadLine()) - 1;

                                var horas = await centroService.GetHorasTotalCursosByCentroIdAsync(listCentros[positionCentro].Id);

                                Console.WriteLine("Horas totales de todos los cursos del centro {0}: {1}", listCentros[positionCentro].Nombre, horas);
                                break;
                            case 6:
                                var listCentrosDelete = await centroService.GetListAsync();
                                Console.WriteLine("Elija una posición para eliminar");
                                var position = Convert.ToInt32(Console.ReadLine())-1;

                                await centroService.DeletePersonaAsync(listCentrosDelete[position].Id);
                                break;
                        }
                        break;
                    #endregion

                    #region Alumno
                    case 2:
                        Console.WriteLine("1-Crear o Editar \n2-Listar \n3-Obtener alumnos de un centro \n4-Eliminar");
                        var optionAlumno = int.Parse(Console.ReadLine());

                        switch (optionAlumno)
                        {
                            case 1:
                                await alumnoService.AddEditAsync(await CreateOrEditAlumnoAsync());
                                break;
                            case 2:
                                await alumnoService.GetListAsync();
                                break;
                            case 3:
                                var listCentros = await centroService.GetListAsync();
                                Console.WriteLine("Elija una posición");
                                var positionCentro = Convert.ToInt32(Console.ReadLine()) - 1;

                                await alumnoService.GetListByCentroIdAsync(listCentros[positionCentro].Id);
                                break;
                            case 4:
                                var listAlumnos = await centroService.GetListAsync();
                                Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
                                var position = Convert.ToInt32(Console.ReadLine()) - 1;

                                await alumnoService.DeletePersonaAsync(listAlumnos[position].Id);
                                break;
                        }
                        break;
                    #endregion

                    #region Profesor
                    case 3:
                        Console.WriteLine("1-Crear o Editar \n2-Listar \n3-Obtener profesores de un centro \n4-Eliminar");
                        var optionProfesor = int.Parse(Console.ReadLine());

                        switch (optionProfesor)
                        {
                            case 1:
                                await profesorService.AddEditAsync(await CreateOrEditProfesorAsync());
                                break;
                            case 2:
                                await profesorService.GetListAsync();
                                break;
                            case 3:
                                var listCentros = await centroService.GetListAsync();
                                Console.WriteLine("Elija una posición");
                                var positionCentro = Convert.ToInt32(Console.ReadLine()) - 1;

                                await profesorService.GetListByCentroIdAsync(listCentros[positionCentro].Id);
                                break;
                            case 4:
                                var listProfesor = await profesorService.GetListAsync();
                                Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
                                var position = Convert.ToInt32(Console.ReadLine()) - 1;

                                await profesorService.DeletePersonaAsync(listProfesor[position].Id);
                                break;
                        }
                        break;
                    #endregion

                    #region Curso
                    case 4:
                        Console.WriteLine("1-Crear o Editar \n2-Listar \n3-Obtener alumnos de un centro \n4-Obtener el curso con más horas \n5-Eliminar");
                        var optionCurso = int.Parse(Console.ReadLine());

                        switch (optionCurso)
                        {
                            case 1:
                                await cursoService.AddEditAsync(await CreateOrEditCursoAsync());
                                break;
                            case 2:
                                await cursoService.GetListAsync();
                                break;
                            case 3:
                                var listCentros = await centroService.GetListAsync();
                                Console.WriteLine("Elija una posición");
                                var positionCentro = Convert.ToInt32(Console.ReadLine()) - 1;

                                await cursoService.GetListByCentroIdAsync(listCentros[positionCentro].Id);
                                break;
                            case 4:
                                var cursos = await cursoService.GetListCursoMaxHorasAsync();

                                foreach(var curso in cursos)
                                {
                                    Console.WriteLine("Curso con más horas: {0}", curso.Nombre);
                                }
                                break;
                            case 5:
                                var listCursos = await cursoService.GetListAsync();
                                Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
                                var positionDelete = Convert.ToInt32(Console.ReadLine()) - 1;

                                await cursoService.DeletePersonaAsync(listCursos[positionDelete].Id);
                                break;
                        }
                        break;
                    #endregion

                    #region Asignatura
                    case 5:
                        Console.WriteLine("1-Crear o Editar \n2-Listar \n3-Obtener asignaturas de un curso \n4-Eliminar");
                        var optionAsignatura = int.Parse(Console.ReadLine());

                        switch (optionAsignatura)
                        {
                            case 1:
                                await asignaturaService.AddEditAsync(await CreateOrEditAsignaturaAsync());
                                break;
                            case 2:
                                await asignaturaService.GetListAsync();
                                break;
                            case 3:
                                var listCursos = await cursoService.GetListAsync();
                                Console.WriteLine("Elija una posición");
                                var positionCurso = Convert.ToInt32(Console.ReadLine()) - 1;

                                await asignaturaService.GetByCursoIdAsync(listCursos[positionCurso].Id);
                                break;
                            case 4:
                                var listCursosDelte = await asignaturaService.GetListAsync();
                                Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
                                var position = Convert.ToInt32(Console.ReadLine()) - 1;

                                await asignaturaService.DeletePersonaAsync(listCursosDelte[position].Id);
                                break;
                        }
                        break;
                        #endregion
                }
            } while (true);
        }

        public async Task<Centro> CreateOrEditCentroAsync()
        {
            var listCentros = await centroService.GetListAsync();
            Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
            var position = Convert.ToInt32(Console.ReadLine())-1;

            Centro cursoAddEdit = new Centro();
            cursoAddEdit.Id = position == 0 ? Guid.Empty : listCentros[position].Id;
            Console.WriteLine("Nombre");
            cursoAddEdit.Nombre = Console.ReadLine();
            Console.WriteLine("CP");
            cursoAddEdit.Cp = Console.ReadLine();

            return cursoAddEdit;
        }

        public async Task<Alumno> CreateOrEditAlumnoAsync()
        {
            var listAlumnos = await alumnoService.GetListAsync();
            Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
            var position = Convert.ToInt32(Console.ReadLine()) - 1;

            Alumno alumnoAddEdit = new Alumno();
            alumnoAddEdit.Id = position == 0 ? Guid.Empty : listAlumnos[position].Id;
            Console.WriteLine("Nombre");
            alumnoAddEdit.Nombre = Console.ReadLine();
            Console.WriteLine("CP");
            //alumnoAddEdit.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Centros");

            var listCentros = await centroService.GetListAsync();
            Console.WriteLine("Elija una posición");
            var positionCentro = Convert.ToInt32(Console.ReadLine()) - 1;

            alumnoAddEdit.CentroId = listCentros[positionCentro].Id;

            return alumnoAddEdit;
        }

        public async Task<Profesor> CreateOrEditProfesorAsync()
        {
            var listProfesor = await profesorService.GetListAsync();
            Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
            var position = Convert.ToInt32(Console.ReadLine()) - 1;

            Profesor profesorAddEdit = new Profesor();
            profesorAddEdit.Id = position == 0 ? Guid.Empty : listProfesor[position].Id;
            Console.WriteLine("Nombre");
            profesorAddEdit.Nombre = Console.ReadLine();
            Console.WriteLine("Telefono");
            profesorAddEdit.Telefono = int.Parse(Console.ReadLine());
            Console.WriteLine("Centros");

            var listCentros = await centroService.GetListAsync();
            Console.WriteLine("Elija una posición");
            var positionCentro = Convert.ToInt32(Console.ReadLine()) - 1;

            profesorAddEdit.CentroId = listCentros[positionCentro].Id;

            return profesorAddEdit;
        }

        public async Task<Curso> CreateOrEditCursoAsync()
        {
            var listCurso = await cursoService.GetListAsync();
            Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
            var position = Convert.ToInt32(Console.ReadLine()) - 1;

            Curso cursoAddEdit = new Curso();
            cursoAddEdit.Id = position == 0 ? Guid.Empty : listCurso[position].Id;
            Console.WriteLine("Nombre");
            cursoAddEdit.Nombre = Console.ReadLine();
            Console.WriteLine("Telefono");
            cursoAddEdit.HorasTotales = int.Parse(Console.ReadLine());
            Console.WriteLine("Centros");

            var listCentros = await centroService.GetListAsync();
            Console.WriteLine("Elija una posición");
            var positionCentro = Convert.ToInt32(Console.ReadLine()) - 1;

            cursoAddEdit.CentroId = listCentros[positionCentro].Id;

            return cursoAddEdit;
        }

        public async Task<Asignatura> CreateOrEditAsignaturaAsync()
        {
            var listaAsignaturas = await asignaturaService.GetListAsync();
            Console.WriteLine("Elija una posición o escriba 0 para crear un nuevo registro");
            var position = Convert.ToInt32(Console.ReadLine()) - 1;

            Asignatura asignaturaAddEdit = new Asignatura();
            asignaturaAddEdit.Id = position == 0 ? Guid.Empty : listaAsignaturas[position].Id;
            Console.WriteLine("Nombre");
            asignaturaAddEdit.Nombre = Console.ReadLine();

            Console.WriteLine("Cursos");
            var listCursos = await cursoService.GetListAsync();
            Console.WriteLine("Elija una posición");
            var positionCentro = Convert.ToInt32(Console.ReadLine()) - 1;

            asignaturaAddEdit.CursoId = listCursos[positionCentro].Id;

            Console.WriteLine("Profesor");
            var listProfesor = await profesorService.GetListAsync();
            Console.WriteLine("Elija una posición");
            var positionProfesor = Convert.ToInt32(Console.ReadLine()) - 1;

            asignaturaAddEdit.ProfesorId = listProfesor[positionProfesor].Id;

            return asignaturaAddEdit;
        }
    }
}
