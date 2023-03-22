using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros
{
    public class ExTheory2
    {
       public ExTheory2()
        {
            //Puedes utilizar la clase File para realizar diferentes operaciones con archivos,
            //como crear, leer o escribir archivos. Para crear un archivo, puedes utilizar el
            //método "Create" de la clase File de la siguiente manera:
            string filePath = @"C:\MiCarpeta\MiArchivo.txt";
            string filePath2 = "C:\\MiCarpeta\\MiArchivo.txt";
            File.Create(filePath); //opcional

            //Ten en cuenta que si el archivo ya existe, este método lo sobrescribirá.

            //Para leer el contenido de un archivo, puedes utilizar el método "ReadAllText"
            //de la clase File de la siguiente manera:
            string filePath3 = "../../../LenguajeAvanzado/ExFicheros/ficheroTexto.txt";
            string contenido = File.ReadAllText(filePath2);
        }

    }
}
