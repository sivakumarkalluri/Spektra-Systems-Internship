using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter Radius of Circle: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.Write("Enter length of Rectangle: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of Rectangle: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Rectangle rect = new Rectangle(l,b);
            Console.Write("Enter Side of Square: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Square sq = new Square(s);

            Console.WriteLine("Area of the Circle is : " + circle.area());
            Console.WriteLine("Area of the Rectangle is : " + rect.area());
            Console.WriteLine("Area of the Square is : " + sq.area());

        }
    }

    abstract class Calculate
    {

        public abstract double area();
    }

    class Circle : Calculate
    {
        double radius;
 
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double area()
        {
            return Math.PI * this.radius * this.radius;
        }
        
    }

    class Rectangle : Calculate
    {
        double length, breadth;
        public Rectangle( double length,double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override double area()
        {
            return this.length * this.breadth;
        }

    }

    class Square : Calculate
    {

        double length;

        public Square(double length)
        {
            this.length = length;
        }
        public override double area()
        {
            return this.length * this.length;
        }

    }
}
