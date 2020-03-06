using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class Loop
    {
        public static void Exercise1()
        //Write a program in C# Sharp to display n terms of natural number and their sum.
        {
            int i, n, sum = 0;

            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural numbers are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);
        }

        public static void Exercise2()
        //Write a program in C# Sharp to read 7 numbers from keyboard and find their sum and average.
        {
            int i, n, sum = 0;
            double avg;

            Console.WriteLine("Enter 7 numbers in order to find their sum and average.");

            for (i = 1; i <= 7; i++)
            {
                Console.WriteLine("Number-{0} :", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 7.0;
            Console.WriteLine("The sum of the 7 numbers is: {0}", sum);
            Console.WriteLine("The Average is: {0}", avg);

        }


        public static void Exercise3()
        //Write a program in C# Sharp to display the n numbers of odd natural number and their sum.
        {
            int i, n, sum = 0;

            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
        }


        public static void Exercise4()
        //Write a program in C# Sharp to make such a pattern like a pyramid with a number which will repeat the number in the same row.
        {
            int i, j, spc, rows, k;

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", i);
                Console.Write("\n");
                spc--;
            }
        }

        public static void Exercise5()
        //Write a program in C# Sharp to display the first n terms of Fibonacci series.
        {
            int number, i, sum;
            int number0 = 0;
            int number1 = 1;

            Console.Write("Input number of terms : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is the fibonacci series up to {0} terms: ", number);
            Console.WriteLine("{0} {1}", number0, number1);


            for (i = 3; i <= number; i++)
            {
                sum = number0 + number1;
                Console.Write("{0} ", sum);
                number0 = number1;
                number1 = sum;
            }
        }


        public static void Exercise6()
        //Write a program in C# Sharp to find the number and sum of all integer between 100 and 200 which are divisible by 9.        
        {
            int number1;
            int number2;
            int sum = 0;
            int number, i;

            Console.WriteLine("Numbers between 100 and 200, divisible by 9: ");

            for (i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write("{0} ", i);
                    sum += i;
                }
            }
            Console.WriteLine("\n" + sum);
        }


        public static void Exercise9()
        //
        {
            int cols, rows;
            Console.Write("Input number of terms : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (rows = 1; rows <= number; rows++)
            {
                for (cols = 1; cols <= rows; cols++)
                {
                    Console.Write("{0}", cols);
                }
                Console.WriteLine();
            }
        }

    }
}




    


    
    

