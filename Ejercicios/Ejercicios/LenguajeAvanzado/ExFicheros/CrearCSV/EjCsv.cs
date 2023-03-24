using DocumentFormat.OpenXml.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.CrearCSV
{
    public class EjCsv
    {
        string delimiter = ";";

        public EjCsv() 
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..");
            string fullpath = Path.GetFullPath(path);
            string realPath = Path.Combine(fullpath, $"LenguajeAvanzado\\ExFicheros\\CrearCSV");
            string filePath = Path.Combine(realPath, "file.csv");

            List<Persona> personas= new List<Persona>()
            {
                new Persona("Alfred","98765",23,"Santander",1000),
                new Persona("Juan","56789",23,"Ibercaja",2000),
                new Persona("Pepito","76543",23,"BBVA",10000),
                new Persona("Laura","34567",23,"BBVA",500),
                new Persona("Alberto","54321",23,"Santander",100),
                new Persona("Alvaro","12345",23,"BancoPixinxa",5000),
            };

            CrearCSV(filePath, personas);

            MostrarCSV(filePath, personas);
           
        }

        public void CrearCSV(string filePath, List<Persona> personas)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Nombre; Contraseña; Contraseña Hash; Edad; Banco; Saldo;");

                foreach(var persona in personas)
                {
                    var line= persona.Nombre+delimiter +
                        persona.Contraseña + delimiter +
                        persona.ContraseñaHash + delimiter +
                        persona.Edad + delimiter +
                        persona.Banco + delimiter +
                        persona.Saldo + delimiter;

                    writer.WriteLine(
                        line
                    );
                }
            }
        }

        public void MostrarCSV(string filePath, List<Persona> personas)
        {
            string[] lines = File.ReadAllLines(filePath);

            string[] headers = lines[0].Split(delimiter);
            int numColumns = headers.Length;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(delimiter);
                Console.WriteLine(string.Join("\t", headers));

                for (int j = 0; j < numColumns; j++)
                {
                    Console.Write(values[j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
