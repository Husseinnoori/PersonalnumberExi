using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalnumber_Exi
{
    class Program
    {
        static int[] months = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };// satic int all months in a year
        static bool ValidateLength(string personalNumber)//decide length of number and return
        {
            return personalNumber.Length == 12;
        } 
        static bool ValidateYear(int year)
        {
            return year >= 1753 && year <= 2020;
        }
        static bool ValidateMonth(int month)
        {
            return month >= 1 && month <= 12;
        } 
        static bool ValidateDay(int year,int month,int day)
        {
            int daysThismonth = months[month];
            if(month==2 && IsLeapYear(year))
            {
                daysThismonth += 1;
            }
            if(day>=1 && day <= daysThismonth)
            {
                return true;
            }
            return false;
        } 
        static bool IsLeapYear(int year) // calculate leap year and make an if and else if sats
        {
            if(year % 400 == 0)
            {
                return true;
            } 
            else if (year% 100 == 0)
            {
                return false;
            }
            else if(year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        static string GetGender (int number)
        {
            if (number % 2 == 0)
            {
                return "female";
            }
            if(number % 2!= 0)
            {
                return "male";
            }
            return "female";
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Write your personal number with 12 numbers:");
            string personnummer = Console.ReadLine();
            int year = int.Parse(personnummer.Substring(0, 4));// first four numbers of the personal number 
            int month = int.Parse(personnummer.Substring(4, 2));// month 
            int day = int.Parse(personnummer.Substring(6, 2));// day 
            int birthNumber = int.Parse(personnummer.Substring(8, 3));//the last numbers 
           
            // The start of the if sats always turns.So if ValidateYear is true it makes it to false.
            if (!ValidateLength(personnummer))
            {
                Console.WriteLine("Not the correct length.");
            }
            else if (!ValidateYear(year))
            {
                Console.WriteLine("Year is invalid.");
            }
            else if (!ValidateMonth(month))
            {
                Console.WriteLine("Month is invalid.");
            }
            else if (!ValidateDay(year, month, day))
            {
                Console.WriteLine("Day is invalid");
            }
            else
            {
                Console.WriteLine($"Number is valid and gender is {GetGender(birthNumber)}");// if you write the right number the program tell you this.
            }

        }
    } 
}
