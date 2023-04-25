using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Calculate calc1 = new Calculate(0);
            calc1.findArea((float)20.3);
            Calculate calc2 = new Calculate(0);
            calc2.findArea(10,20);
            Calculate output = calc1 + calc2;
            Console.WriteLine($"Total area ({calc1.area} + {calc2.area}) =  " + output.area);


        }

        class Calculate
        {
            public double area;
            float radius;
            int side;
            int length, width;

            public Calculate(double Area)
            {
                this.area = Area;
            }

            //************* Method Overloading *****************
            public void findArea(float radius)
            {
                this.area = Math.PI * radius * radius;
            }
            public void findArea(int side)
            {
                this.area = side*side;
            }
            public void findArea(int length, int width)
            {
                this.area = length * width;
            }

            //**************  Operator Overloading  ****************
            public static Calculate operator + (Calculate calc1,Calculate calc2)
            {
                Calculate result = new Calculate(calc1.area+calc2.area);
                return result;
            }
        }
    }
}
