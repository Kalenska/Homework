using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class Conditions
    {
        public static void Excercise1()
        {
            while (true)
            {
                Console.WriteLine("Input first integer");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Input second integer");
                int y = int.Parse(Console.ReadLine());

                if (x < 0 && y >= 0)
                {
                    Console.WriteLine("Check if one is negative and one is positive: True");
                }
                if (x >= 0 && y < 0)
                {
                    Console.WriteLine("Check if one is negative and one is positive: True");
                }
                else if (x >= 0 && y >= 0 && x <= 0 && y <= 0)
                {
                    Console.WriteLine("Check if one is negative and one is positive: False");
                }
            }
        }

        public static void Excercise2()
        // OK 
        {
            while (true)
            {
                Console.WriteLine("Input first integer");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Input second integer");
                double y = double.Parse(Console.ReadLine());

                double absolute = (x - y);
                double abslValue = Math.Abs(absolute);
                Console.WriteLine(abslValue);

                if (x > y)
                {
                    double doubleAbsolute = (abslValue * 2);
                    Console.WriteLine(doubleAbsolute);
                }
            }
        }


        public static void Excercise3()
        // 
        {
            while (true)
            {
                Console.WriteLine("Input first integer");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Input second integer");
                int y = int.Parse(Console.ReadLine());

                int sum = (x + y);


                if (sum == 20 || x == 20 || y == 20)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        public static void Excercise4()
        // Oк
        {
            while (true)
            {
                Console.WriteLine("Input first integer");
                int x = int.Parse(Console.ReadLine());

                if ((x >= 80 && x <= 120) || (x >= 180 && x <= 220))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        public static void Excercise5()
        // Oк
        {
            {
                while (true)
                {
                    double x, y;
                    char operation;

                    Console.Write("Input first number: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input operation: ");
                    operation = Convert.ToChar(Console.ReadLine());
                    Console.Write("Input second number: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    if (operation == '+')
                    {
                        Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                    }
                    else if (operation == '-')
                    {
                        Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                    }
                    else if ((operation == '*') || (operation == 'x'))
                    {
                        Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                    }
                    else if (operation == '/')
                    {
                        Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Character");
                    }
                }
            }
        }

        public static void Excercise6()
            //ok
        {
            {
                while (true)
                {
                    Console.Write("Input day Number: ");
                    int x = int.Parse(Console.ReadLine());

                    switch (x)
                    {
                        case 1: Console.WriteLine("Monday"); break;
                        case 2: Console.WriteLine("Tuesday"); break;
                        case 3: Console.WriteLine("Wednesday"); break;
                        case 4: Console.WriteLine("Thursday"); break;
                        case 5: Console.WriteLine("Friday"); break;
                        case 6: Console.WriteLine("Saturday"); break;
                        case 7: Console.WriteLine("Sunday"); break;
                        default: Console.WriteLine("Wrong day number"); break;
                    }
                }
            }

        }
    }
}







































