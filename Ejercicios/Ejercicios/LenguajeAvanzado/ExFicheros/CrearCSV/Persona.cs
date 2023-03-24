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
        public string ContraseñaHash { get; set; }
        public int Edad { get; set; }
        public string Banco { get; set; }
        public int Saldo { get; set; }

        public Persona(string nombre, string contraseña, int edad, string banco, int saldo)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            ContraseñaHash = ComputeHash(contraseña);
            Edad = edad;
            Banco = banco;  
            Saldo = saldo;
        }

        private string ComputeHash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder stringB = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringB.Append(hashBytes[i].ToString("X2"));
                }

                return stringB.ToString();
            }
        }
    }
}
