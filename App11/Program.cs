
/*
*  Program 11-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
*  
*  W tym ćwiczeniu, w pierwotnej wersji, zastosowałem instrukcję warunkową switch.
*  Ale pomyslałem, że mniej kodu zajmie zastosowanie enum-a.
*  Tym bardziej, że chciałem sobie go przećwiczyć.
*  
*/

using System.ComponentModel;

namespace App11
{
    internal class Program
    {
        private enum Grade
        {
            Nie_ma_takiej_oceny = 0,
            Niedostateczny,
            Dopuszczający,
            Dostateczny,
            Dobry,
            Bardzo_dobry,
            Celujący            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź swoją ocenę (1-6):");
            int grade = AppsBackend.DataGetter.GetIntFromString();                        
            grade = (1 <= grade && grade <= 6) ? grade : 0;

            String yourGrade = AppsBackend.DataGetter.SetSpacesInEnum((Grade)grade);
            Console.WriteLine($"\nTwoja ocena to: {yourGrade}");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
} 