using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson2
{
    class Strings
    {
        public static void Excercise1()
        //Write a C# program to create a new string from a given string where the first and last characters will change their positions.
        //ok
        {
            Console.WriteLine("Input a string");
            string str = (Console.ReadLine());

            char first = str[0];
            char last = str[str.Length - 1];
            Console.WriteLine(last + str.Substring(1, str.Length - 2) + first);
        }

        public static string Exercise()
        //other solution to the first task 
        {
            Console.WriteLine("Input a string");
            string str = Console.ReadLine();

            char first = str[0];
            string last = str.Substring(str.Length - 1);
            return last + str.Substring(1, str.Length - 2) + first;
        }


        public static void Excercise2()
        //Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
        {
            while (true)
            {

                {
                    Console.WriteLine("Input any word or sentense - length 1 or more");
                    string inputString = (Console.ReadLine());

                    char first = inputString[0];
                    Console.WriteLine(first + inputString + first);
                }
            }
        }


        public static void Excercise3()
        //Write a C# program to reverse the words of a sentence.
        {
            while (true)
            {
                {
                    Console.WriteLine("Input any word or sentense");
                    string inputString = (Console.ReadLine());

                    //Console.WriteLine(String.Join("", Console.ReadLine().ToCharArray().Reverse()));

                    string resultString = string.Join("", inputString.Reverse());
                    Console.WriteLine(resultString);
                }
            }

        }

        public static void Excercise4()
        //Write a C# program to check if a given string contains ‘c’ character between 1 and 3 times.
        {
            while (true)
            {

                {
                    Console.WriteLine("Input a string.");
                    string inputString = Console.ReadLine();

                    var count = inputString.Count(s => s == 'c');
                    Console.WriteLine("Test if the string containc 'c' character 1 or 3 times");
                    Console.WriteLine(count >= 1 && count <= 3);
                }
            }
        }

        public static void Excercise5()
        //Write a C# Sharp program that takes a character as input and check the input (lowercase) is a letter, a digit, or any other symbol.        
        {
            while (true)
            {
                {
                    Console.WriteLine("Input a character.");
                    char inputString = Convert.ToChar(Console.ReadLine());
                   

                    if (char.IsLetter(inputString))
                    {
                        Console.WriteLine("It's a lowercase letter.: " + char.ToLower(inputString));
                    }
                    else if (char.IsDigit(inputString))
                    {
                        Console.WriteLine("It's a digit.");
                    }
                    else
                    {
                        Console.WriteLine("It's a symbol.");
                    }

                    /*char character = char.Parse(Console.ReadLine());
                    char lowerCharacter = char.ToLower(character);

                    if (char.IsLetter(lowerCharacter))
                    {
                        Console.WriteLine($"{lowerCharacter} is a lowercase letter");
                    }
                    */
                }
            }
        }

        public static void Excercise6()
        //Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
        {
            while (true)
            {
                string answer;
                string result;

                Console.Write("Input a Number : ");
                answer = Console.ReadLine();

                int num = Convert.ToInt32(answer);
                result = "";
                while (num > 1)
                {
                    int remainder = num % 2;
                    result = Convert.ToString(remainder) + result;
                    num /= 2;
                }
                result = Convert.ToString(num) + result;
                Console.WriteLine("Binary: {0}", result);
            }
        }
    }
               
}
