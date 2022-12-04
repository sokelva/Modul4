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

            //int A = 5;
            //int B = 3;
            //double X = 5;
            //double Y = 4;

            //bool C = (A < B) | (X > Y);

            //Console.WriteLine(C);
            //Console.ReadKey();

            //var a = 5 + 6;
            //var b = 7 + 8;

            //var c = (b != a) & (b > a + 1);
            //var d = (b != a) && (b > a + 1);

            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.ReadKey();

            //var a = 5 + 6;
            //var b = 7 + 8;

            //var c = (b == a) & (b > a + 1);
            //var d = (b == a) && (b > a + 1);

            //var a = 6;
            //var b = 7;

            //if (a == b)
            //{
            //    Console.WriteLine("Условие истинно");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Условие ложно");
            //    if (b < 10)
            //    {
            //        Console.WriteLine("Значение b = {0} меньше 10", b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Значение b = {0} больше 10", b);
            //    }


            //var a = 6;
            //var b = 7;

            //if (a == b)
            //{
            //    Console.WriteLine("Условие истинно");
            //}
            //else if (b < 10)
            //{
            //    Console.WriteLine("Значение b = {0} меньше 10", b);
            //}
            //else
            //{
            //    Console.WriteLine("Значение b = {0} больше 10", b);
            //}


            //var a = 6;
            //var b = 7;

            //if (a == b && b > 1)
            //{
            //    Console.WriteLine("Условие истинно");
            //}
            //else if (b > 10 || b == 7)
            //{
            //    Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            //}
            //else
            //{
            //    Console.WriteLine("Значение b = {0}", b);
            //}

            //Тернарные операции
            //var a = 6;
            //var b = 7;

            //var c = a != b ? a + b : b;

            //Console.WriteLine(c);

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
            Console.ReadKey();
            
        }
    }
}
