
using System;
using System.Security.Cryptography.X509Certificates;

namespace Figures
{
    public interface IPrint
    {
        void Print();
    }
    public abstract class Figure : IPrint, IComparable
    {
        public abstract double Square();

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public int CompareTo(object obj)
        {
            Figure f = obj as Figure;
            if (f != null)
            {
                return Square().CompareTo(f.Square());
            }
            else
                throw new ArgumentException("Сравнение не с фигурой!");
        }
    }
    public class Rectangle : Figure
    {
        protected double h { get; set; }
        protected double w { get; set; }
        public Rectangle(double height, double weight)
        {
            h = height;
            w = weight;
        }
        public override double Square()
        {
            return h * w;
        }
        public override string ToString()
        {
            return $"Прямоугольник: Высота: {h}, Ширина: {w}, Площадь {Square()}";
        }
    }
    public class Quadrat : Rectangle
    {
        public Quadrat(double a) : base(a, a) { }
        public override string ToString()
        {
            return $"Квадрат: Сторона: {h}, Площадь {Square()}";
        }
    }
    public class Circle : Figure
    {
        private double r { get; set; }
        public Circle(double radius)
        {
            r = radius;
        }
        public override double Square()
        {
            return r * r * Math.PI;
        }
        public override string ToString()
        {
            return $"Круг: Радиус: {r}, Площадь {Square()}";
        }
    }
}

