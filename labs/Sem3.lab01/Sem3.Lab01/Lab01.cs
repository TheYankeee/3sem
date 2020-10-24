using System;
using System.Collections.Generic;

namespace Sem3.Lab01
{
    class Lab01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Кучумов Вячеслав Олегович, ИУ5-33Б");
            double a=0, b=0, c=0;
            Boolean fa=true,fb=true,fc=true;
            List<double> solutions = new List<double>();


            if (args.Length == 3)
            {
                if (!double.TryParse(args[0], out a)||(a==0))
                {
                    Console.WriteLine("Ошибка ввода в коммандной строке для A!");
                }
                else fa = false;
                if (!double.TryParse(args[1], out b))
                {
                    Console.WriteLine("Ошибка ввода в коммандной строке для B!");
                }
                else fb = false;
                if (!double.TryParse(args[2], out c))
                {
                    Console.WriteLine("Ошибка ввода в коммандной строке для C!");
                }
                else fc = false;
            }


            if (fa)
            {
                Console.WriteLine("Введите коэффициент A");
                while (!double.TryParse(Console.ReadLine(), out a)||(a==0))
                {
                    Console.WriteLine("Введите число, неравное 0, для A!");
                }
            }
            if (fb)
            {
                Console.WriteLine("Введите коэффициент B");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Введите число для B!");
                }
            }
            if (fc)
            {
                Console.WriteLine("Введите коэффициент A");
                while (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Введите число для C!");
                }
            }


            double d = b * b - 4 * a * c;
            if ((-b + Math.Sqrt(d)) / (2 * a) >= 0)
            {
                solutions.Add(Math.Sqrt((-b + Math.Sqrt(d)) / (2 * a)));
                if (-Math.Sqrt((-b + Math.Sqrt(d)) / (2 * a)) != Math.Sqrt((-b + Math.Sqrt(d)) / (2 * a)))
                    solutions.Add(-Math.Sqrt((-b + Math.Sqrt(d)) / (2 * a)));
            }
            if (((-b - Math.Sqrt(d)) / (2 * a) >= 0)&&(d!=0))
            {
                solutions.Add(Math.Sqrt((-b - Math.Sqrt(d)) / (2 * a)));
                solutions.Add(-Math.Sqrt((-b - Math.Sqrt(d)) / (2 * a)));
            }


            if (solutions.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет решений!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (var i = 0; i < solutions.Count; i++)
                    Console.WriteLine($"x{i+1} = {solutions[i]}");
                Console.ResetColor();
            }
        }
    }
}
