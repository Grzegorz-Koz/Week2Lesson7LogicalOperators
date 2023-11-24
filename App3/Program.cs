
/*
*  Program 3-ci z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
*  
*  
*/

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą. Sprawdzę, czy jest ona dodatnia.\n");
            Console.WriteLine("Liczba:");
            int intToCheck = AppsBackend.DataGetter.GetIntFromString();

            String isPositive = intToCheck > 0 ? "dodatnia" : "ujemna";
            Console.WriteLine($"\nPodana liczba jest {isPositive}.");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}