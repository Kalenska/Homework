using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
    class Arrays
    {
        public static void Ex1()
        //Write a Method to find the sum of all elements of the array.
        {
            int[] a = new int[100];
            int i, n, sum = 0;

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element-{0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }


        public static void Ex2()
        //2. Write a Method  to count a total number of duplicate elements in an array.
        {
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            int[] array3 = new int[100];
            int stored1, stored2, mm = 1, ctr = 0;
            int i, j;
            Console.Write("\n\nCount total number of duplicate elements in an array:\n");
            Console.Write("---------------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            stored1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", stored1);
            for (i = 0; i < stored1; i++)
            {
                Console.WriteLine("Element-{0} :", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*----------------- copy in other array ------------------------------------*/
            for (i = 0; i < stored1; i++)
            {
                array2[i] = array1[i];
                array3[i] = 0;
            }

            /*------------------- mark the duplicated elements -------------------------*/
            for (i = 0; i < stored1; i++)
            {
                for (j = 0; j < stored1; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        array3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }

            /*--------------- Prints the array ------------------------------------*/
            for (i = 0; i < stored1; i++)
            {
                if (array3[i] == 2) { ctr++; }
            }
            Console.Write("The number of duplicate elements is: {0} \n", ctr);

            Console.Write("\n\n");
        }
    }

}



    

