﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTasks
{
    class Class1
    {
        public static void Exercise1()
        {
            double surcharge;
            double ratio;
            double add = 1;
            Console.WriteLine("Enter Customer ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name: ");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter UNIT Consumed: ");
            int unit = Convert.ToInt32(Console.ReadLine());

            if (unit <= 199)
            {
                surcharge = unit * 1.2;
                ratio = 1.2;
            }
            else if (unit < 400)
            {
                surcharge = unit * 1.5;
                ratio = 1.5;

            }
            else if (unit < 600)
            {
                surcharge = unit * 1.8;
                ratio = 1.8;
            }
            else
            {
                surcharge = unit * 2;
                ratio = 2;
            }
            Console.WriteLine("Customer IDNO: " + id);
            Console.WriteLine("Customer Name:  " + name);
            Console.WriteLine("Unit Consumed:  " + unit);
            Console.WriteLine($"Amount Charges @Rs. {ratio} per unit:  " + surcharge.ToString("F2"));

            if (unit > 400)
            {
                add = surcharge * 0.15;
            }
            Console.WriteLine("Surcharge Amount: " + add.ToString("F2"));
            Console.WriteLine("Amount Paid by the user: " + (surcharge + add));
        }


        public static string UrlFormat(string url, string section, int id)
        {

            if (url.Contains("/section") && url.Contains("/id"))
            {
                url = url.Replace("section", section);
                url = url.Replace("id", id + "");
            }
            else if (url.Contains("/section"))
            {
               url =  url.Replace("section", section);
            }
            else if (url.Contains("/id"))
            {
               url = url.Replace("id", id + "");
            }
            else
            {
                url = "Error.";
            }
            return url;
        }

        public static string UrlParamsFormat(string url, string section, int id)
        {

            if (url.Contains("=section") && url.Contains("=id"))
            {
                url = url.Replace("section", section);
                url = url.Replace("id", id + "");
            }
            else if (url.Contains("=section"))
            {
                url = url.Replace("section", section);
            }
            else if (url.Contains("=id"))
            {
                url = url.Replace("id", id + "");
            }
            else
            {
                url = "Error.";
            }
            return url;
        }
    }
}


