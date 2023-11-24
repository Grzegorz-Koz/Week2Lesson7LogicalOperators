
/*
 *  Program 7-my z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 */

namespace App7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj kilka liczb całkowitych. Sprawdzę, która z nich jest największa.");
            Console.WriteLine("Ile liczb chcesz sprawdzić (1-10)?:");
            int numberOfIntegerToCheck = AppsBackend.DataGetter.GetIntFromString(1, 10);
            Console.WriteLine();

            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i < numberOfIntegerToCheck; i++) 
            {
                Console.WriteLine($"Wpisz liczbę {i+1}:");
                listOfNumbers.Add(AppsBackend.DataGetter.GetIntFromString());
            }

            listOfNumbers.Sort();
            Console.WriteLine($"\nNajwiększa liczba jaką wpisałeś to: {listOfNumbers.Last()}.");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();

        }
    }
}