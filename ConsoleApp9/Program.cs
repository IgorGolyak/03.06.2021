using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.55(в)
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 10;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1, 20);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    mas[i] = mas[i] - b;
                }

                else
                {
                    mas[i] = mas[i] + a;
                }
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
