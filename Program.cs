using System;

namespace Sort_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to sort: ");
            int howManyNumbers = int.Parse(Console.ReadLine());
            Random_Numbers(howManyNumbers);
        }

        private static int [] Random_Numbers(int nr)
        {
            int[] tab = new int[nr];

            Random rnd = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rnd.Next(20);
            }

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("{0,5}", tab[i]);
            }
            return tab;
        }
    }
}
