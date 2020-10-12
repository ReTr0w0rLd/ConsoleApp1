using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] t = new int[100];
            for (int j = 0; j < t.Length; j++)
            {
                t[j] = rnd.Next(1,9999);
                Console.WriteLine($"{t[j]}, ");
            }
            
            int sum = 0;
            for (int i = 0; i < t.Length; i++)
            {
                sum += t[i];
            }
            Console.WriteLine($"\nÖsszeg: {sum}");

            int c = 0;
            int d = 5;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] % d == 0) c++;
            }
            Console.WriteLine($"{d}-al/-el osztható számok: {c} db");
            Console.ReadKey();


        }
        
        
    }
}
