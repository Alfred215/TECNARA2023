using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Polimorfismo
{
    public class EjercicioPolimorfirsmo
    {
        /*En este ejemplo, la clase Animal define un método Speak virtual 
         * que se sobrescribe en las clases derivadas Cat y Dog. En el 
         * método Main, se crea un array de tres objetos de la clase Animal,
         * pero se les asignan instancias de la clase Animal, Cat y Dog. En 
         * el bucle foreach, se llama al método Speak de cada uno de los 
         * objetos, lo que demuestra el polimorfismo. Dependiendo del objeto 
         * en cuestión, se llamará a la versión adecuada del método Speak. */
        public EjercicioPolimorfirsmo() {
            Animal[] animals = new Animal[3];
            animals[0] = new Animal();
            animals[1] = new Cat();
            animals[2] = new Dog();

            foreach (Animal animal in animals)
            {
                animal.Speak();
            }
        }
    }
}
