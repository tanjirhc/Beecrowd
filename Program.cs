using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, aux;
            input = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} ano(s)", input/365);
            aux =(input%365);


            Console.WriteLine("{0} mes(es)", aux/365);
            aux = (aux%30);

            Console.WriteLine("{0} dia(s)", aux / 1);
            Console.ReadKey();
        }
    }
}
