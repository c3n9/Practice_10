using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало промежутка");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец промежутка");
            double j = double.Parse(Console.ReadLine());
            double sum = 0;
            for (double k = i; k <= j; k++)
            {
                if (i % 2 != 0)
                {
                    i = -i;
                }
                i += 3;
                sum += i;
            }
            Console.WriteLine($"Ответ: {sum}");
        }
    }
}
