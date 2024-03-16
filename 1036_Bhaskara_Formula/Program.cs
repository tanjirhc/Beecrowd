using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1036_Bhaskara_Formula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, r1, r2;

            String oneLineInput = Console.ReadLine();

            string[] value = oneLineInput.Split(' ');
            a = double.Parse(value[0]);
            b = double.Parse(value[1]);
            c = double.Parse(value[2]);


            if ((a == 0) || (((b * b) - (4 * a * c)) < 0))
            {
                Console.WriteLine("Impossivel calcular");

            }
            else
            {

                r1 = ((-b + Math.Sqrt(((b * b) - (4 * a * c)))) / (2 * a));
                r2 = ((-b - Math.Sqrt(((b * b) - (4 * a * c)))) / (2 * a));

                Console.WriteLine("R1 = {0:f5}", r1);
                Console.WriteLine("R2 = {0:f5}", r2);

            }
            Console.ReadKey(); 
        }
    }
}
