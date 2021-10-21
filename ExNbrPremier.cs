using System;

namespace nombrepremier
{
    class Program
    {
        static void main(string[] args)
        {
            int x;
            int i;
            int m = 0;

            Console.WriteLine("Entrer un nombre : ");
            x = int.Parse(Console.ReadLine());

            
            if (x == 0 || x == 1)
            {
                Console.WriteLine("ressayer");

            }
            else
            {

                for (i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        m = 1;
                        break;
                    }

                }
                if (m == 0)
                {
                    Console.WriteLine("ce nombre est premier");
                }
                else
                {
                    Console.WriteLine("le nombre n'est pas premier ");
                }
            }

        }
    }
}

