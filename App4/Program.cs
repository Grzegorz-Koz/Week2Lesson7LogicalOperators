
/*
 *  Program 4-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 *  W tym ćwiczeniu poprzednie, zagłębione instrukcje warunkowe if, zastąpiłem 
 *  operatorem: Ternary Operator.
 *  
 */

using Microsoft.VisualBasic;

namespace App4
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Wpisz rok, który chciałbyś sprawdzić:");
            
            //Lata nie mogą być liczbą mniejszą niż 0:
            int year = AppsBackend.DataGetter.GetGreaterIntFromString(0);
            
            Console.WriteLine("\r");
            
            bool isDivisibleBy4NotBy100 = (year % 4) == 0 && !((year % 100) == 0) ? true : false;
            string isNotLeapYear = isDivisibleBy4NotBy100 ? "" : (year % 400) == 0 ? "" : "nie ";
            
            Console.WriteLine($"Rok, który wpisałeś ({year}), {isNotLeapYear}jest rokiem przestępnym.");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}