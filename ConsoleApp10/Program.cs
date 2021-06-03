using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.71
            //В массиве записаны оценки ученика по 10 предметам. Определить общее
            //количество четверок и пятерок
            int n = 10;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(2, 6);
                Console.Write(mas[i]);
            }
            int a = 0;
            int b = 0;
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                if (mas[i] == 4)
                {
                    a = a + 1;
                }
                else if (mas[i] == 5)
                {
                    b = b + 1;
                }
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
