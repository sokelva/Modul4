using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string A= "--";
            //string B = "234";
            //bool C = A != B;

            int A = 5;
            int B = 3;
            double X = 5;
            double Y = 4;

            bool C = (A < B) | (X > Y);

            Console.WriteLine(C);
            Console.ReadKey();

        }
    }
}
