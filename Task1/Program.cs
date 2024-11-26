using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            Console.WriteLine("Введите значение коэффициента K");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение коэффициента B");
            double b = Convert.ToDouble(Console.ReadLine());

            LinearEquation linearEquation = new LinearEquation(k,x,b);
            Console.WriteLine(linearEquation.Root());
            Console.ReadKey();

        }
    }
}
