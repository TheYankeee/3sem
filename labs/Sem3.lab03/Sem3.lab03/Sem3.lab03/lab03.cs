using System;
using Figures;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyList;
using MyStack;
using MySparseMatrix;

namespace Lab3
{
    class Lab03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кучумов Вячеслав Олегович, ИУ5-33Б");
            Rectangle rect = new Rectangle(2, 3);
            Quadrat quad = new Quadrat(5);
            Circle circle = new Circle(3);

            Console.WriteLine("\nArrayList");
            ArrayList a1 = new ArrayList();
            a1.Add(circle);
            a1.Add(rect);
            a1.Add(quad);
            foreach (var x in a1) Console.WriteLine(x.ToString());
            Console.WriteLine("\nArrayList-sort");
            a1.Sort();

            foreach (var x in a1) Console.WriteLine(x.ToString());
            Console.WriteLine("\nList<Figure>");
            List<Figure> f1 = new List<Figure>();
            f1.Add(circle);
            f1.Add(rect);
            f1.Add(quad);

            foreach (var x in f1) Console.WriteLine(x.ToString());
            Console.WriteLine("\nList<Figure>-sort");
            f1.Sort();

            foreach (var x in f1) Console.WriteLine(x.ToString());
            Console.WriteLine("\nMatrix");
            SparseMatrix<Figure> matrix= new SparseMatrix<Figure>(4, 4, 4, null);
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 1] = quad;
            matrix[3, 3, 3] = circle;
            Console.WriteLine(matrix.ToString());

            Console.WriteLine("\nStack");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rect);
            stack.Push(quad);
            stack.Push(circle);
            foreach (var x in stack) Console.WriteLine(x.ToString());

            Console.WriteLine("\nStack-pop");
            stack.Pop();
            foreach (var x in stack) Console.WriteLine(x.ToString());
        }
    }
}
