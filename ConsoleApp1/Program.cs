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

            //var color = Console.ReadLine();

            //if (color == "red")
            //{
            //    Console.BackgroundColor = ConsoleColor.Red;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Your color is red!");
            //}

            //else if (color == "green")
            //{
            //    Console.BackgroundColor = ConsoleColor.Green;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Your color is green!");
            //}
            //else
            //{
            //    Console.BackgroundColor = ConsoleColor.Cyan;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Your color is cyan!");
            //}
            //------------------------------------------------------------------------------------
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //var color = Console.ReadLine();

            //switch (color)
            //{
            //    case "red":
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is red!");
            //        break;

            //    case "green":
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is green!");
            //        break;

            //    case "cyan":
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is cyan!");
            //        break;

            //    default:
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.ForegroundColor = ConsoleColor.Red;

            //        Console.WriteLine("Your color is {0}!", color);
            //        break;
            //}
            //---------------------------------------------------------------------------------------
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            ////var color = Console.ReadLine();

            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("Iteration {0}", i);
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }
            //}

            //int i = 1;
            //for (i = 5; i > 0; i--)
            //{
            //    Console.WriteLine("Iteration {0}", i);
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;
            //        case "yellow":
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is Yellow!");
            //            break;
            //    }
            //
            //}
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //var color = Console.ReadLine();

            //switch (color)
            //{
            //    case "red":
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is red!");
            //        break;

            //    case "green":
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is green!");
            //        break;

            //    case "cyan":
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is cyan!");
            //        break;

            //    default:
            //        //continue;
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is yellow!");
            //        //continue;
            //        break;
            //}
            //Console.ReadKey();
            //------------------------------------------------------------------------------------

            ////Размерность массива 
            //var arr = new int[] { 1, 2, 3, 4 };
            //var l = arr.Length;

            ////Разные виды инициализации массива
            //int[] arr1 = new int[4] { 1, 2, 3, 5 };
            //int[] arr2 = new int[] { 1, 2, 3, 5 };
            //int[] arr3 = new[] { 1, 2, 3, 5 };
            //int[] arr4 = { 1, 2, 3, 5 };

            //foreach (var ch in name)
            //{
            //    Console.Write(ch + " ");
            //}

            //Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

            //Console.ReadKey();

            //Console.WriteLine("Введите своё имя");

            //var name = Console.ReadLine();

            //Console.WriteLine("Ваше имя по буквам: ");
            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(name[i]+" ");

            //}
            //Console.ReadKey();

            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            //Console.WriteLine(array[0, 1]);

            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey();
            //Длинна двумерного массива----------------------------------------------------
            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            //Console.WriteLine(array.Length);
            //Console.WriteLine(array.GetUpperBound(1));

            //// ходим по элементам двумерного массива
            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            //        Console.Write(array[i, k] + " ");

            //    Console.WriteLine();
            //}


            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            //        Console.Write(array[i, k] + " ");

            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //// программа
            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            //for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
            //        Console.Write(array[k, i] + " ");

            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //int temp;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}
            //Console.ReadKey();
            //--------------------------------------------------------------------------
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine(sum);

            //---------Зубчатый массив
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }
            Console.ReadKey();
        }
    
    }
}
