using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Calculation
    {
        public void Calculations()
        {
            int a;
            int b;
            int sum;
            int difference;
            int product;

            //Calculations:
            Console.WriteLine("Enter number?");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number?");
            b = int.Parse(Console.ReadLine());

            sum = a + b;
            Console.WriteLine("The sum of the two numbers is: " + sum);

            difference = a - b;
            Console.WriteLine("The difference between the two numbers is: " + difference);

            product = a * b;
            Console.WriteLine("The product of the two numbers is: " + product);
        }
    }
}