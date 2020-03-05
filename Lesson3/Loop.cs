using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class Loop
    {
        public static void Excercise1()
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

         public static void Excercise2()
         //Write a program in C# Sharp to read 7 numbers from keyboard and find their sum and average.
        {
            int i, n, sum = 0;
            double avg;

            Console.WriteLine("Enter 7 numbers in order to find their sum and average.");

            for (i=1; i <= 7; i++)
            {
                Console.WriteLine("Number-{0} :", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 7;
            Console.WriteLine("The sum of the 7 numbers is: {0}", sum);
            Console.WriteLine("The Average is: {0}", avg);

        }


        public static void Excercise3()
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


        public static void Excercise4()
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

        public static void Excercise5()
        //Write a program in C# Sharp to display the first n terms of Fibonacci series.
        {

        }
    }

}
    


    
    

