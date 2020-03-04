using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Operations
    {
        public void Operation()
        {
            int r;
            int x;
            int y;

            int height;
            int side;

            //Operations 1 
            Console.WriteLine("Enter number - \"a\"?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number - \"b\"?");
            int b = int.Parse(Console.ReadLine());
            double result1 = Math.Pow(a, 2) + 2*a*b + Math.Pow(b, 2);
            Console.WriteLine("(a + b)^2 is: " + result1);

            //Operations 2 
            Console.WriteLine("Enter a number - \"r\"?");
            r = int.Parse(Console.ReadLine());
            double result2 = Math.PI *  Math.Pow(r,2);
            Console.WriteLine("(Pi*r)^2 is: " + result2);

            //Operations 3 
            Console.WriteLine("Enter a number?");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The number is even.");
                Console.ReadLine();
            }
            else
                {
                Console.WriteLine("The number is odd.");
                Console.ReadLine();
            }

            //Operations 4 
            Console.WriteLine("Enter first number - x?");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number - y?");
            y = int.Parse(Console.ReadLine());
            double result5 = Math.Pow(x, y);
            Console.WriteLine("x^y is: " + result5);

            //Operation 5
            Console.WriteLine("Enter height of a triangle?");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side of a triange?");
            side = int.Parse(Console.ReadLine());
            double result6 = height * side / 2;
            Console.WriteLine("The area of the triange is: " + result6);

        }
    }
}