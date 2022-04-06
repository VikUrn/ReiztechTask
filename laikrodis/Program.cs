using System;

namespace laikrodis
{
    internal class Program
    {        
        static void Main(string[] args)
        {

            Console.WriteLine("Write a hours");
            int h = int.Parse(Console.ReadLine());

            if (h > 12 || h < 0)
            {
                Console.WriteLine("Write a hours from 1 to 12");
                Console.ReadLine();
            }

            Console.WriteLine("Write a minut");
            int m = int.Parse(Console.ReadLine());

            if (m > 60 || m < 1)
            {
                Console.WriteLine("Write a minuts from 1 to 60");
                Console.ReadLine();
            }

            int counta = ((h * 5) - m) * 6;

            if (counta > 90)
            {
                counta = 180 - counta;
            }

            int countb = (m - (h * 5)) * 6;

            if (countb > 90)
            {
                countb = 180 - countb;
            }

            if ((h * 5) > m)
            {
                Console.WriteLine("Answer");
                Console.WriteLine(counta);
            }
            else
            {
                Console.WriteLine("Answer");
                Console.WriteLine(countb);
            }

        }
    }
}
