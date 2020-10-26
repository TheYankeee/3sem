
using System;
using System.Security.Cryptography.X509Certificates;

namespace Sem3.Lab02
{
    public interface IPrint
    {
        void Print();
    }
    public abstract class Figure : IPrint
    {
        public abstract double Square();

        public void Print()
        {
            Console.WriteLine(this.ToString());
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
            return $"Высота: {h}, Ширина: {w}, Площадь {Square()}";
        }
    }
    public class Quadrat : Rectangle
    {
        public Quadrat(double a) : base(a, a) { }
        public override string ToString()
        {
            return $"Сторона: {h}, Площадь {Square()}";
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
            return $"Радиус: {r}, Площадь {Square()}";
        }
    }
    class lab02
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2, 3);
            rect.Print();
            Quadrat quad = new Quadrat(5);
            quad.Print();
            Circle circle = new Circle(3);
            circle.Print();
        }
    }
}
