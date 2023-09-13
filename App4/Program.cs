
/*
 *  Program 4-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 *  The logic of finding if the given year is a "leap year" I found in:
 *  https://learn.microsoft.com/pl-pl/office/troubleshoot/excel/determine-a-leap-year
 *  
 */

using Microsoft.VisualBasic;

namespace App4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isLeapYear = false;
            
            Console.WriteLine("Enter the year you would like to check:");
            int year = int.Parse(Console.ReadLine());
            
            string isLeapYearInfo = "The year you entered (" + year + ") is the \"leap year\"";
            string notLeapYearInfo = "The year you entered (" + year + ") is not the \"leap year\"";

            if ((year % 4) == 0)
            {
                if ((year % 100) == 0)
                {
                    if ((year % 400) == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }

            Console.WriteLine("\r");
            if (isLeapYear) {
                Console.WriteLine(isLeapYearInfo);
            }
            else
            {
                Console.WriteLine(notLeapYearInfo);
            }            
        }
    }
}