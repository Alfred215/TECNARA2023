using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.LenguajeAvanzado.ExThreads.EjCarrera
{
    public class EjCarrera
    {
        List<Car> cars = new List<Car>();
        List<Thread> threads = new List<Thread>();

        static int raceDuration;
        static Random rnd = new Random();

        public EjCarrera()
        {
            Console.Write("Numero de coches: ");
            var carsnum = int.Parse(Console.ReadLine());

            Console.Write("Duración de la carrera: ");
            raceDuration = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsnum; i++)
            {
                cars.Add(new Car(i, 0));
            }

            foreach (var car in cars)
            {
                threads.Add(new Thread(new ThreadStart(car.CarRace)));
            }

            foreach (var thread in threads)
            {
                thread.Start();
            }

            Thread timerThread = new Thread(new ThreadStart(Timer));
            timerThread.Start();

            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.Clear();
            GetWinner();

        }

        public void Timer()
        {
            for (int i = 0; i < raceDuration; i++)
            {
                Console.WriteLine("Time remaining: {0} seconds", raceDuration - i);
                Thread.Sleep(1000);
            }

            foreach (var car in cars)
            {
                car.raceOver = true;
            }
        }

        public void GetWinner()
        {
            int winner = 0;
            int maxDistance = 0;

            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].distance > maxDistance)
                {
                    winner = i;
                    maxDistance = cars[i].distance;
                }
            }

            Console.WriteLine("Race is over!");
            Console.WriteLine("Winner: Car {0} with a distance of {1} meters.", cars[winner + 1].CarId, maxDistance);
        }
    }
}
