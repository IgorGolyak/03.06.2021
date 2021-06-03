using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.89
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = 10;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-10,10);
                Console.Write(mas[i]);
            }
            Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                if (mas[i] == 5)
                {
                    mas[i] = mas[i] + 1;
                }
                else if (mas[i] == -6)
                {
                   mas[i] = mas[i] - 1;
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
