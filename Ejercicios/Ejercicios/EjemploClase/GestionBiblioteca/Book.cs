using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.EjemploClase.GestionBiblioteca
{
    public class Book
    {
        public string Tittle;
        public string Auth;
        public int Year;
        public string Genre;
        public int Code;
        public bool isRented;

        public Book(string titulo, string autor, int año, string genero, int codigo)
        {
            Tittle = titulo;
            Auth = autor;
            Year = año;
            Genre = genero;
            Code = codigo;
            isRented = false;
        }
    }
}
