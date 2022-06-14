using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("**** Enter your array lenght:  ");
            int[] ia = new int[Convert.ToInt32(Console.ReadLine())];
            Random r=new Random();
            for (int i = 0; i <= ia.Length; i++)
            {
                ia[i] = r.Next(0, 100);
                Console.WriteLine(ia[i].ToString());
            }
            Console.WriteLine("-------------------------");
            Array.Sort(ia);
            for (int i = 0; i <= ia.Length; i++)
            {
                Console.WriteLine(ia[i].ToString());
            }
            Console.ReadKey();
            
        }
    }
}
