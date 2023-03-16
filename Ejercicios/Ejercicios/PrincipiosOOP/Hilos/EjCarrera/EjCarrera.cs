using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Hilos.EjCarrera
{
    public class EjCarrera
    {
        static int numberOfCars;
        static int raceDuration;
        static int distance = 0;
        static bool raceOver = false;
        static Random rnd = new Random();

        public EjCarrera()
        {
            Console.Write("Numero de coches: ");
            numberOfCars = int.Parse(Console.ReadLine());

            Console.Write("Duración de la carrera: ");
            raceDuration = int.Parse(Console.ReadLine());

            Thread[] carThreads = new Thread[numberOfCars];

            for (int i = 0; i < numberOfCars; i++)
            {
                carThreads[i] = new Thread(new ThreadStart(CarRace));
                carThreads[i].Start();
            }

            Thread timerThread = new Thread(new ThreadStart(Timer));
            timerThread.Start();

            for (int i = 0; i < numberOfCars; i++)
            {
                carThreads[i].Join();
            }

            timerThread.Abort();

            Console.WriteLine("Race is over!");
            Console.WriteLine("Winner: Car {0} with a distance of {1} meters.", GetWinner() + 1, distance);
        }

        static void CarRace()
        {
            int carNumber = Thread.CurrentThread.ManagedThreadId;
            int currentSpeed = 0;

            while (!raceOver)
            {
                currentSpeed = rnd.Next(0, 101);
                distance += currentSpeed;

                Console.WriteLine("Car {0} is at {1} meters with a speed of {2} km/h", carNumber, distance, currentSpeed);

                Thread.Sleep(1000);
            }
        }

        static void Timer()
        {
            for (int i = 0; i < raceDuration; i++)
            {
                Console.WriteLine("Time remaining: {0} seconds", raceDuration - i);
                Thread.Sleep(1000);
            }

            raceOver = true;
        }

        static int GetWinner()
        {
            int winner = 0;
            int maxDistance = 0;

            for (int i = 0; i < numberOfCars; i++)
            {
                if (distance > maxDistance)
                {
                    winner = i;
                    maxDistance = distance;
                }
            }

            return winner;
        }
    }
}
