using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int k = 0;
            int hour = int.Parse(Console.ReadLine());
            for(int i = 0; i < hour; i++)
            {
                if (i % 3 == 0)
                {
                    a *= 2;
                }
                k++;
            }
            Console.WriteLine($"Через {k} часов будет {a} амебы");
        }
    }
}
