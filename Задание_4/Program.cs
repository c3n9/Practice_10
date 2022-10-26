using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Введите число ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Делители : {0}", i);
                    s += i;
                }
            }
            if (s == n)
            {
                Console.WriteLine("{0} Сумма является совершенным числом", n);
            }
            else
            {
                Console.WriteLine("{0} Сумма не является совершенным числом", n);
            }
           
            

        }
    }
}
