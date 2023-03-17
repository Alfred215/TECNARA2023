using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Hilos.EjCarrera
{
    public class Car
    {
        public int CarId { get; set; }
        public int distance { get; set; }

        public bool raceOver { get; set; } = false;

        Random rnd = new Random();

        public Car (int carId, int distance)
        {
            CarId = carId;
            this.distance = distance;
        }

        public void CarRace()
        {
            int carNumber = Thread.CurrentThread.ManagedThreadId;
            int currentSpeed = 0;
            int distance = 0;

            while (!raceOver)
            {
                currentSpeed = rnd.Next(0, 101);
                distance += currentSpeed;

                Console.WriteLine("Car {0} is at {1} meters with a speed of {2} km/h", carNumber, distance, currentSpeed);
            }
        }

        public int ReturnDistance()
        {
            return distance;
        }
    }
}
