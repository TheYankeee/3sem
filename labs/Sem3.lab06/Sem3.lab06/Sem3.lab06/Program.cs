using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Sem3.lab06
{

    public delegate T TwoVarsOperations<T>(T p1, T p2);

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Делегаты");

            int a = 3;
            int b = 4;
            string result;

            result = string.Format("Через делегата: " + Delegate.Calculate(a, b, Delegate.Multiply).ToString() + "\nЧерез лямбду: "
                + Delegate.Calculate(a, b, (int a, int b) => a * b).ToString());
            Console.WriteLine(result);

            result = string.Format("Функция через Делегата: " + Delegate.CalculateFunc(a, b, Delegate.Multiply).ToString() +
                "\nФункция через лямбду: "+ Delegate.CalculateFunc(a, b, (int a, int b) => a * b).ToString());
            Console.WriteLine("\n"+result);

            Action<int, int> a1 = (x, y) => { Console.WriteLine("{0} * {1} = {2}", x, y, x * y); };
            Action<int, int> a2 = (x, y) => { Console.WriteLine("{0} / {1} = {2}", x, y, x / y); };
            Action<int, int> group = a1 + a2;

            Console.WriteLine("\nПример группового делегата");
            group(8, 2);

            Console.WriteLine("\nИзначальный групповой делегат");
            Action<int, int> group2 = a1;
            group2(8, 2);
            Console.WriteLine("\nДобавление вызова метода к групповому делегату");
            group2 += a2;
            group2(8, 2);
            Console.WriteLine("\nУдаление вызова метода из группового делегата");
            group2 -= a1;
            group2(8, 2);

           
            
            Console.WriteLine("\n\nРефлексия");

            Type test = typeof(Test);

            Console.WriteLine("Конструкторы:");

            foreach (var constructor in test.GetConstructors())
            {
                Console.WriteLine(constructor.Name);
            }

            Console.WriteLine("\nПоля:");

            foreach (var field in test.GetFields())
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("\nМетоды");

            foreach (var method1 in test.GetMethods())
            {
                Console.WriteLine(method1.Name);
            }

            Console.WriteLine("\nСвойства");

            foreach (var property in test.GetProperties())
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine("\nЧлены класса с атрибутом MyAttribute: ");

            foreach (var member in test.GetMembers())
            {
                foreach (var attribute in member.GetCustomAttributes())
                {
                    if (attribute is MyAttribute)
                    {
                        Console.WriteLine(member.Name + " " + attribute.ToString());
                    }
                }
            }

            Console.WriteLine("\n");

            MethodInfo method = test.GetMethod("Print", new Type[] { });

            Test maths_test = new Test(name:"Ivan", res:4, new_topic:"Maths", code:1);
            method.Invoke(maths_test, new Object[] { });
        }
    }
}
