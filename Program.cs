using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int  i = 1;  i < n; i++) 
            {
                s = 0 + 2 * i - 1;
                s = 2 + 2 * i - 1;
                s = 3 + 2 * i - 1;
                s = 4 + 2 * i - 1;
                break; 
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
