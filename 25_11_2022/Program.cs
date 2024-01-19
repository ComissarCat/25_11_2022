using System;
using System.Collections.Generic;

namespace _25_11_2022
{
    internal class Program
    {
        abstract class Figure
        {
            protected abstract double Calculate_P();
            protected abstract double Calculate_S();
            public abstract void Show_parameters();
        }
        class Triangle : Figure
        {
            public double a { get; set; }
            public double b { get; set; }
            public double c { get; set; }
            public Triangle()
            {
                a = 3;
                b = 4;
                c = 5;
            }
            protected override double Calculate_P() { return a + b + c; }
            protected override double Calculate_S() { return Math.Sqrt(Calculate_P() * (Calculate_P() - a) * (Calculate_P() - b) * (Calculate_P() - c)); }
            public override void Show_parameters() { Console.WriteLine($"Треугольник:\na = {a}\nb = {b}\nc = {c}\nP = {String.Format("{0:F2}", Calculate_P())}\nS = {String.Format("{0:F2}", Calculate_S())}"); }
        }
        class Square : Figure
        {
            public double a { get; set; }
            public Square()
            {
                a = 5;
            }
            protected override double Calculate_P() { return a * 4; }
            protected override double Calculate_S() { return a * a; }
            public override void Show_parameters() { Console.WriteLine($"Квадрат:\na = {a}\nP = {String.Format("{0:F2}", Calculate_P())} \nS =  {String.Format("{0:F2}", Calculate_S())}"); }
        }
        class Rhomb : Figure
        {
            public double a { get; set; }
            public double d { get; set; }
            public double D { get; set; }
            public Rhomb()
            {
                a = 5;
                d = 4;
                D = Math.Sqrt(4 * a * a - d * d);
            }
            protected override double Calculate_P() { return a * 4; }
            protected override double Calculate_S() { return d * D * 0.5; }
            public override void Show_parameters() { Console.WriteLine($"Ромб:\na = {a}\nP = {String.Format("{0:F2}", Calculate_P())}\nS = {String.Format("{0:F2}", Calculate_S())}"); }
        }
        class Rectangle : Figure
        {
            public double a { get; set; }
            public double b { get; set; }
            public Rectangle()
            {
                a = 5;
                b = 4;
            }
            protected override double Calculate_P() { return 2 * a + 2 * b; }
            protected override double Calculate_S() { return a * b; }
            public override void Show_parameters() { Console.WriteLine($"Прямоугольник:\na = {a}\nb = {b}\nP = {String.Format("{0:F2}", Calculate_P())}\nS = {String.Format("{0:F2}", Calculate_S())}"); }
        }
        class Circle : Figure
        {
            public double r { get; set; }
            public Circle()
            {
                r = 5;
            }
            protected override double Calculate_P() { return 2 * Math.PI * r; }
            protected override double Calculate_S() { return Math.PI * r * r; }
            public override void Show_parameters() { Console.WriteLine($"Круг:\nr = {r}\nP = {String.Format("{0:F2}", Calculate_P())}\nS = {String.Format("{0:F2}", Calculate_S())}"); }
        }
        static void Main()
        {
            List<Figure> figures = new List<Figure>
            {
                new Triangle(),
                new Square(),
                new Rhomb(),
                new Rectangle(),
                new Circle()
            };
            foreach (Figure f in figures)
            {
                f.Show_parameters();
                Console.WriteLine();
            }
        }
    }
}
