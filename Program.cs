﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[]args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a\nnew line?";
            //string myString = "Got to your c:\\ drive";
            //string myString = @"Got to your c:\ drive";

            //string myString = String.Format("{1} = {0}", "First", "Second");

            //string myString = string.Format("{0:C}", 123.45); //for currency
            //string myString = string.Format("{0:N}", 1234567890); //adding formating for appropriate numbers
            //string myString = string.Format("Percantage: {0:P}", .123);
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890); //custom format

            //string myString = " That summer we took threes across the board  ";

            //myString = myString.Substring(6, 14); //range of string characters displayed
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--"); //replacing characters
            //myString = myString.Remove(6, 14); // range of string characters removed

            /*
            myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length, 
                myString.Trim().Length);
            */

            /*
            string myString = " ";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
                //myString += i.ToString() + "--";
            }
            */

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
