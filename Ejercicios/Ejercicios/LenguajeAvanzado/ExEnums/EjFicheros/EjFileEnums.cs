using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExEnums.EjFicheros
{
    internal class EjFileEnums
    {
        public void MenuFile()
        {
            List<File> files = new List<File>();

            // Creamos algunos objetos de prueba
            files.Add(new TextFile("Archivo de texto", ".txt", DateTime.Now, 10));
            files.Add(new TextFile("Archivo de texto1", ".txt", DateTime.Now, 10));
            files.Add(new TextFile("Archivo de texto2", ".txt", DateTime.Now, 10));
            files.Add(new TextFile("Archivo de texto3", ".txt", DateTime.Now, 10));
            files.Add(new ImageFile("Img", ".jpg", DateTime.Now.AddDays(-1), 800, 600));
            files.Add(new ImageFile("Img", ".jpg", DateTime.Now.AddDays(-3), 800, 600));
            files.Add(new ImageFile("Img", ".jpg", DateTime.Now.AddDays(10), 800, 600));
            files.Add(new ImageFile("Img", ".jpg", DateTime.Now.AddDays(2), 800, 600));
            files.Add(new AudioFile("Cancion", ".mp3", DateTime.Now.AddMonths(1), 245, 128));
            files.Add(new AudioFile("Cancion1", ".mp3", DateTime.Now.AddMonths(2), 220, 128));
            files.Add(new AudioFile("Cancion2", ".mp3", DateTime.Now.AddMonths(7), 260, 128));
            files.Add(new AudioFile("Cancion3", ".mp3", DateTime.Now.AddMonths(-1), 20, 128));

            while (true)
            {
                Console.WriteLine("Elije una opción:");
                Console.WriteLine("1. Buscar en el listado por nombre y tipo.");
                Console.WriteLine("2. Renombrar un objeto del listado por otro nombre que pida por consola.");
                Console.WriteLine("3. Borrar del listado un objeto por el nombre que introduces.");
                Console.WriteLine("4. Ordenar archivos por tamaño");
                Console.WriteLine("5. Mostrar listado de todos los archivos que tienen una A");
                Console.WriteLine("6. Mostrar listado de audios ordenados por tiempo.");
                Console.WriteLine("7. Mostrar listado ordenado por fecha de creación descendente.");
                Console.WriteLine("8. Salir");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Introduce el nombre:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Introduce el tipo (Texto = 0, Imagen = 1, Audio = 2):");
                        int fileType = int.Parse(Console.ReadLine());
                        FileType type = (FileType)fileType;
                        var matchingFiles = files.FirstOrDefault(f => f.Name == name && f.FileType == type);
                        if (matchingFiles == null)
                        {
                            Console.WriteLine("No se encontraron archivos que coincidan.");
                        }
                        else
                        {
                            Console.WriteLine("Archivos encontrados:");
                            Console.WriteLine($"{matchingFiles.Name}{matchingFiles.Extension} - {matchingFiles.FileType} - {matchingFiles.CreationDate}");

                        }
                        break;
                    case "2":
                        Console.WriteLine("Introduce el nombre actual:");
                        string currentName = Console.ReadLine();
                        var fileToRename = files.FirstOrDefault(f => f.Name == currentName);
                        if (fileToRename == null)
                        {
                            Console.WriteLine("No se encontró ningún archivo con ese nombre.");
                        }
                        else
                        {
                            Console.WriteLine($"Introduce el nuevo nombre para {fileToRename.Name}:");
                            string newName = Console.ReadLine();
                            fileToRename.Name = newName;
                            Console.WriteLine("Archivo renombrado.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Introduce el nombre del archivo a borrar:");
                        string nameToDelete = Console.ReadLine();
                        var fileToDelete = files.FirstOrDefault(f => f.Name == nameToDelete);
                        if (fileToDelete == null)
                        {
                            Console.WriteLine("No se encontró ningún archivo con ese nombre.");
                        }
                        else
                        {
                            files.Remove(fileToDelete);
                            Console.WriteLine("Archivo borrado.");
                        }
                        break;
                    case "4":
                        var sortedFiles = files.OrderBy(f => f.Size).ToList();
                        Console.WriteLine("Listado de archivos ordenados por tamaño:");
                        foreach (var file in sortedFiles)
                        {
                            Console.WriteLine($"Nombre: {file.Name}, Tamaño: {file.Size} bytes");
                        }
                        break;
                    case "5":
                        var fileWithA = files.Where(x => x.Name.ToLower().Contains("a")).ToList();
                        foreach (var file in fileWithA)
                        {
                            Console.WriteLine(file.Name);
                        }
                        Console.WriteLine();
                        return;
                    case "6":
                        var fileAudioOrderTime = files.Where(x => x.FileType == FileType.Audio).OrderBy(x => x.Duration()).ToList();
                        foreach (var file in fileAudioOrderTime)
                        {
                            Console.WriteLine(file.Name);
                        }
                        Console.WriteLine();
                        return;
                    case "7":
                        var fileOrderDesc = files.OrderByDescending(x => x.CreationDate).ToList();
                        foreach (var file in fileOrderDesc)
                        {
                            Console.WriteLine(file.Name);
                        }
                        Console.WriteLine();
                        return;
                    case "8":
                        // Salir
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
