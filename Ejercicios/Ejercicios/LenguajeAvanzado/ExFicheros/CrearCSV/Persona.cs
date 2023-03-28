using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExFicheros.CrearCSV
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public int ContraseñaHash { get; set; }
        public int Edad { get; set; }
        public string Banco { get; set; }
        public int Saldo { get; set; }

        public Persona(string nombre, string contraseña, int edad, string banco, int saldo)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            ContraseñaHash = contraseña.GetHashCode();
            Edad = edad;
            Banco = banco;  
            Saldo = saldo;
        }

        /*Este código implementa una función que toma una cadena de entrada y calcula su hash MD5, 
         * que es una función criptográfica que toma una entrada de cualquier longitud y devuelve 
         * una cadena de 128 bits.*/
        private string ComputeHash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                //convierte la cadena de entrada en una matriz de bytes utilizando la codificación UTF-8.
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                //calcula el hash de la matriz de bytes de entrada utilizando el algoritmo MD5 y devuelve el resultado como una matriz de bytes.
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder stringB = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    //Agrega el byte actual a la cadena de salida en formato hexadecimal.
                    stringB.Append(hashBytes[i].ToString("X2"));
                }

                return stringB.ToString();
            }
        }
    }
}
