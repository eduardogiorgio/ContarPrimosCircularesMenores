using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading;


namespace primoCircular
{

    public class classPrimoCircular
    {
        // acceso a la pantalla
        Form1 pantalla = new Form1();

        private SortedSet<int> primes;
        private int limiteSearch;
        public  int show { get; private set; }
   
    
        public void setLimitSearch(int valor)
        {
            limiteSearch = valor;
        }

        public void comenzar()
        {

          
            int CircularPrimes = 2;
            primes = new SortedSet<int>(ESieve(limiteSearch));

            //Special cases
            // Revision
            primes.Remove(2);
            primes.Remove(5);

            // seccion puede pausar

            Console.WriteLine("worker thread: working...");
            while (primes.Count > 0)
            {

                CircularPrimes += CheckCircularPrimes(primes.Min);

            }

            Console.WriteLine("el numero total de primos circulares dpor debajo de " + limiteSearch + " es:" + CircularPrimes);
          

            // ver como llamar

            show = CircularPrimes;
     
            Console.WriteLine("show:" + show);

            Console.WriteLine("Termino");


        }

        public int getShow()
        {
            return show;
        }
   

      
        public int[] ESieve(int upperLimit)
        {
            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();
        }

        // obteneida del sitio y verificado 
        // con la pagina ayuda de la pagina http://primes.utm.edu/glossary/xpage/CircularPrime.html 

        public int CheckCircularPrimes(int prime)
        {
            int multiplier = 1;
            int number = prime;
            int count = 0;
            int d;

            //Count the digits and check for even numbers
            while (number > 0)
            {
                d = number % 10;
                // optimizacion del codigo estos digitos no permiten la circularidad
                if (d % 2 == 0 || d == 5)
                {
                    primes.Remove(prime);
                    return 0;
                }
                number /= 10;
                multiplier *= 10;
                count++;
            }
            multiplier /= 10;

            //Rotate the number and check if they are prime
            number = prime;
            List<int> foundCircularPrimes = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (primes.Contains(number))
                {
                    foundCircularPrimes.Add(number);
                    primes.Remove(number);
                }
                else if (!foundCircularPrimes.Contains(number))
                {
                    return 0;
                }

                d = number % 10;
                number = d * multiplier + number / 10;
            }

            return foundCircularPrimes.Count;
        }






    }
}