
/*
*  Program 3-ci z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
*  
*  
*/

using Microsoft.VisualBasic;

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą. Sprawdzę, czy jest ona dodatnia.\n");
            Console.WriteLine("Liczba:");
            int intToCheck = AppsBackend.DataGetter.GetIntFromString();

            string positiveOrNegative = "Podana liczba jest ";
            string zeroInfo = "Zero nie jest ani dodatnie ani ujemne.";
                      
            string checkResult = intToCheck == 0 ? zeroInfo : intToCheck > 0 ? 
                                 positiveOrNegative + "dodatnia." : positiveOrNegative + "ujemna.";
                                  
            Console.WriteLine($"\n{checkResult}");
            Console.ReadKey();
        }
    }
}