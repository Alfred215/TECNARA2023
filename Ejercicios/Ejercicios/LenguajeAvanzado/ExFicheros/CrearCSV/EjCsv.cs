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
            string path = Path.GetFullPath(@"..\..\..\LenguajeAvanzado\ExFicheros\CrearCSV");
            string filePath = Path.Combine(path, "file.csv");

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
                    var line = persona.Nombre + delimiter +
                        persona.Contraseña + delimiter +
                        persona.ContraseñaHash + delimiter +
                        persona.Edad + delimiter +
                        persona.Banco + delimiter +
                        persona.Saldo + delimiter;

                    writer.WriteLine(line);
                }
            }
        }

        public void MostrarCSV(string filePath, List<Persona> personas)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var row in lines)
            {
                var columns = row.Split(delimiter);

                if (row == lines.FirstOrDefault()) //Cabecera
                {
                    Console.WriteLine("{0,-15} {1,-20} {2,-35} {3,-10} {4,-20} {5,-10} ",
                        columns[0], columns[1], columns[2], columns[3], columns[4], columns[5]);
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                } 
                else
                {
                    Console.WriteLine("{0,-15} {1,-20} {2,-35} {3,-10} {4,-20} {5,-10} ", 
                        columns[0], columns[1], columns[2], columns[3], columns[4], columns[5]);
                }
            }
        }
    }
}
