using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.PrincipiosOOP.Hilos.EjSuma
{
    public class EjSuma
    {
        int threadCount = 5;
        long sum = 0;
        static int hilo = 0;

        public EjSuma()
        {
            Thread[] threads = new Thread[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(new ThreadStart(ComputeSum));
                threads[i].Start();
            }

            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine("Sum of even numbers from {0} to {1} is {2}", 0, 10, sum);

        }

        static void ComputeSum()
        {
            var hiloActual = hilo++;
            long localSum = 0;

            for (int i = 0; i < 10; i += 1)
            {
                localSum += i;
                //Thread.Sleep(500);
                Console.WriteLine("El hilo {0} => {1}", hiloActual, localSum);
            }

            Console.WriteLine("Añadir a la suma {0} el hilo actual {1} => {2}", Interlocked.Add(ref sum, localSum), hiloActual, localSum);
        }
    }
}
