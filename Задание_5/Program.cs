using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int d = 0; d <= 64; d++)
            {
                for (int r = 0; r <= 64 / 2; r++)
                {
                    if (d * 2 + r * 4 == 64)
                    {
                        Console.WriteLine($"{d} гусей, {r} кроликов");
                    }
                }
            }
        }
    }
}
