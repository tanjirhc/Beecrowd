using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Test1_1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            String oneLine = Console.ReadLine();

            string[] inputValue = oneLine.Split(' ');
            a = int.Parse(inputValue[0]);
            b = int.Parse(inputValue[1]);
            c = int.Parse(inputValue[2]);
            d = int.Parse(inputValue[3]);

            int cd = c + d;
            int ab = a + b;

            if (b > c && d > a && cd > ab && c > 0 && d > 0)
            {

                if (a % 2 == 0)
                {
                    //Accepted values
                    Console.WriteLine("Valores aceitos");

                }
                else
                {
                    //Values not accepted
                    Console.WriteLine("Valores nao aceitos");
                }
            }
            else
            {
                //Values not accepted
                Console.WriteLine("Valores nao aceitos");
            }
            Console.ReadKey();
        }
    }
}
