using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало промежутка");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец промежутка");
            double j = double.Parse(Console.ReadLine());
            double s = 0;
            for (double k = i; k < j; k++)
            {
                s += 1 / Math.Sin(k);
            }
            Console.WriteLine($"Ответ последовательность (1/sin1)+(1/sin2)+(1/sin3)... = {s}");
        }
    }
}
