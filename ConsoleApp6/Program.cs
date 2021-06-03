using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.55(а)
            int n = 10;
            int[] mas = new int[n];
            int sum = 0;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-20, 20);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                if (mas[i]<0)
                {
                    sum = sum + mas[i];
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
