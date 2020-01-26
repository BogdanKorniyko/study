using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plusiki
{
    class Program
    {
        public int Sum(int a, int b)=> a+b;
            //{
            //return a+b

            //}
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.Sum(a, b);
            Console.WriteLine("Summa: " +program.Sum(a, b));
            Console.ReadKey();
         

        }
    }
}
