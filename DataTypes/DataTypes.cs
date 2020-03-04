using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class DataTypes
    {
        public void Run()
        {
            string firstName;
            string lastName;
            string city;
            string street;
            string houseNumber;
            string age;
            string university;

            //Problem 1 
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What city are you from?");
            city = Console.ReadLine();

            Console.WriteLine("Enter your street?");
            street = Console.ReadLine();

            Console.WriteLine("Which is your house number");
            houseNumber = Console.ReadLine();

            string response = ("Name: " + firstName + " " + lastName + ", Address: " + city + ", " + street + " " + houseNumber);
            Console.WriteLine(response);

            //Problem 2
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            Console.WriteLine("Enter your university?");
            university = Console.ReadLine();

            string response1 = ("Name: " + firstName + " " + lastName + ", Age: " + age);
            string response2 = ("University: " + university);
            Console.WriteLine(response1);
            Console.WriteLine(response2);
        }
    }
}
