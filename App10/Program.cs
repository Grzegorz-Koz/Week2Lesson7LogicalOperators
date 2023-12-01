
/*
 *  Program 10-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 */

namespace App10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] segments = new int[3];
            Console.WriteLine("Podaj dlugości trzech odcinków, z których chcesz zbudować trójkąt:\n");
            for (int i = 0; i < segments.Length; i++)
            {
                Console.WriteLine($"Odcinek {i+1}:");
                segments[i] = AppsBackend.DataGetter.GetGreaterIntFromString(1);
            }

            bool canFormTriangle = 
                Math.Abs(segments[1] - segments[2]) < segments[0] 
                         && segments[0] < segments[1] + segments[2];

            Console.WriteLine(canFormTriangle
                ? "\nZ podanych odcinków można utworzyć trójkąt." 
                : "\nZ podanych odcinków nie można utworzyć trójkąta.");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}