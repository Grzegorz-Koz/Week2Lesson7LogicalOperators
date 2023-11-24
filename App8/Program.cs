
/*
 *  Program 8-my z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 */

namespace App8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] justification =
            {
                "- Ze wszystkich przedmiotów uzyskałeś więcej niż 180 punków.\n",
                "- Z matematyki oraz jednego z przedmiotów uzyskałeś więcej niż 150 punktów."
            };
            
            Console.WriteLine("Aby sprawdzić, czy możesz ubiegać się o miejsce na studiach,");
            Console.WriteLine("wpisz wyniki z matury.\n");
            
            Console.WriteLine("Matematyka:");
            int pointsOfMathematics = AppsBackend.DataGetter.GetGreaterIntFromString(0);
            Console.WriteLine("Fizyka:");
            int pointsOfPhysics = AppsBackend.DataGetter.GetGreaterIntFromString(0);
            Console.WriteLine("Chemia:");
            int pointsOfChemistry = AppsBackend.DataGetter.GetGreaterIntFromString(0);
            
            string finalJustification = "";
            finalJustification = pointsOfMathematics + pointsOfPhysics + pointsOfChemistry > 180 
                                 ? finalJustification += justification[0] : finalJustification;
            finalJustification = pointsOfMathematics + 
                                 (pointsOfPhysics >= pointsOfChemistry ? pointsOfPhysics : pointsOfChemistry) > 150
                                 ? finalJustification += justification[1] : finalJustification;

            if (!String.IsNullOrEmpty(finalJustification)) {
                Console.WriteLine("\nMożesz ubiegać się o miejsce na studaich. Uzasadnienie:");
                Console.WriteLine(finalJustification);
            }
            else
            {
                Console.WriteLine("\nNie możesz ubiegać się o miejsce na studaich. Nie spełniłeś wymagań.");
            }

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();


        }
    }
}