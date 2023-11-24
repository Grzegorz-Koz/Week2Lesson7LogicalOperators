
/*
*  Program 5-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
*  
*  W Polsce nie ma określonego wieku dla Premiera.
*  Nie wiem jak to jest w praktyce, ale przyjąłem, że
*  przyszły premier musi najpierw być posłem. 
*  Dlatego musi mieć ukończone 21 lat.
 */

using Microsoft.VisualBasic;

namespace App5
{
    
    internal class Program
    {        
        private enum StatePosition
        {
            Poseł = 21,
            Senator = 30,
            Prezydent = 35,
            Premier = 21 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wiek. Sprawdzę jakie stanowiska możesz pełnić w Polsce.");
            Console.WriteLine("Twój wiek:");

            // Żeby coś wpisać, trzeba się w końcu urodzić -:)
            int userAge = AppsBackend.DataGetter.GetGreaterIntFromString(1);                                               
            
            string[] possibilitiesInfo = new string[]
            {
                "\nNie masz ukończonych 21 lat.\nNie możesz ubiegać się o żadne stanowisko państwowe.",
                "\nMożesz ubiegać się o następujące stanowiska: "
            };

            if (userAge < 21)
            {
                Console.WriteLine(possibilitiesInfo[0]);
            } else
            {
                bool firstLoop = true;
                string commaSign;
                String listOfPositions = "";
                int statePositionIndex;
                foreach (string statePosition in Enum.GetNames(typeof(StatePosition)))
                {
                    commaSign = firstLoop ? "" : ", ";
                    statePositionIndex = (int)Enum.Parse(typeof(StatePosition), statePosition);
                    listOfPositions = userAge >= statePositionIndex ? listOfPositions + commaSign + statePosition : listOfPositions;
                    firstLoop = false;
                }
                Console.WriteLine(possibilitiesInfo[1] + listOfPositions);
            }
            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();            
        }
    }
}