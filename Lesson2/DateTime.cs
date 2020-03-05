using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    class DateTime
    {
        private static DateTime Now;
        private int DayOfWeek;

        public static void Excercise1()
        {
            while (true)
            {
                //vars
                string fourHundred;
                string oneHundred;
                string four;

                Console.WriteLine("Enter an year to check if it is a Leap year.");
                int nYear = Convert.ToInt32(Console.ReadLine());

                //checks to see if year leaves a remainder to determine if leap year
                int by400 = nYear % 400;
                if (by400 == 0)
                {
                    fourHundred = "Divisible by 400: Yes";
                }
                else
                {
                    fourHundred = "Divisible by 400: No";
                }

                int by100 = nYear % 100;
                if (by100 == 0)
                {
                    oneHundred = "Divisible by 100: Yes";
                }
                else
                {
                    oneHundred = "Divisible by 100: No";
                }

                int by4 = nYear % 4;

                if (by4 == 0)
                {
                    four = "Divisible by 4: Yes";
                }
                else
                {
                    four = "Divisible by 4: No";

                }

                int even = nYear % 2;

                //display all operations
                Console.WriteLine("Year:" + nYear);
                Console.WriteLine(fourHundred);
                Console.WriteLine(oneHundred);
                Console.WriteLine(four);

                //determine if leap year
                if ((even == 0) && (by4 == 0) && (by100 == 0) && (by400 == 0))
                {
                    Console.WriteLine("Leap year: Yes");
                }
                else if ((even == 0) && (by4 == 0) && (by100 != 0) && (by400 != 0))
                {
                    Console.WriteLine("Leap year: Yes");
                }
                else
                {
                    Console.WriteLine("Leap year: No");
                }

            }
        }

        public static void Excercise2()
        //Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
        {
            while (true)
            {
                Console.WriteLine("Enter a month number (from 1 to 12).");
                int monthNumber = Convert.ToInt32(Console.ReadLine());
                int daysInMonth = System.DateTime.DaysInMonth(2020, monthNumber);

                if (daysInMonth >= 30)
                {
                    int dayInMonth = System.DateTime.DaysInMonth(2020, monthNumber);
                    Console.WriteLine(dayInMonth);
                }
                else if (daysInMonth < 30)
                {
                    int feb = System.DateTime.DaysInMonth(2020, monthNumber);
                    Console.WriteLine(feb);
                }
                else
                {
                    Console.WriteLine("Wrong day number.");
                }
            }
        }
        public static void Excercise3()
        //Write a C# Sharp program to display the Day properties (year, month, day, hour, minute, second, millisecond etc.) of the current time.
        //???
        {

            System.DateTime moment = new System.DateTime(2016, 8, 16, 3, 57, 32, 11);

            Console.WriteLine("year = " + moment.Year);

            Console.WriteLine("month = " + moment.Month);

            Console.WriteLine("day = " + moment.Day);

            Console.WriteLine("hour = " + moment.Hour);

            Console.WriteLine("minute = " + moment.Minute);

            Console.WriteLine("second = " + moment.Second);

            Console.WriteLine("millisecond = " + moment.Millisecond);
        }


        public static void Excercise4()
        //Write a C# Sharp program to get the day of the week for a specified date.
        {
            System.DateTime date = System.DateTime.Now;
            Console.WriteLine("The day of the week for {0:d} is {1}.", date, date.DayOfWeek);
            //($"The day of the week for {date:d} is {date.DayOfWeek}.");

        }

        public static void Excercise5()
        //Write a C# Sharp program to calculate what day of the week is 40 days from this moment.
        {
            System.DateTime date = System.DateTime.Now;
            System.DateTime futureDate = date.AddDays(40);
            Console.WriteLine("Current date and time: " + date);
            Console.WriteLine($"The day of the week 40 days from this moment is {futureDate.DayOfWeek}.");
        }


        public static void Excercise6()
        //Write a C# Sharp program to convert the specified Windows file time to an equivalent UTC time.
        {
            System.DateTime dt = System.DateTime.FromFileTimeUtc(12123123123123123);
            System.Console.WriteLine(dt);
        }

        public static void Excercise7()
        //Write a C# Sharp program that compares two dates given by the user in the console.
        {

            System.DateTime date1 = new System.DateTime(2015, 8, 1, 0, 0, 0);
            System.DateTime date2 = new System.DateTime(2015, 8, 1, 0, 0, 0);

            if (date1 > date2)
            {
                Console.WriteLine(date1 + " is earlien than " + date2);
            }
            else if (date1 == date2)
            {
                Console.WriteLine(date1 + " is equal to " + date2);
            }
            else
            {
                Console.WriteLine(date1 + " is later than " + date2);
            }
        }

    }
}



