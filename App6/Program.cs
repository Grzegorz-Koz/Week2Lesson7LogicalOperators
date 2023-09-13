
/*
 *  Program 6-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 */

namespace App6
{
    internal class Program
    {                
        static void Main(string[] args)
        {

            string[] heightCategories = {
            "Small",
            "Medium",
            "Large",
            "There is not such category -:)"
        };

            Console.WriteLine("Enter your growth:");
            int growth = int.Parse(Console.ReadLine());
            string outputInfo;
            Program program = new Program();

            if (0 <= growth && growth  <= 140)
            {
                outputInfo = program.getInfo(heightCategories[0]);
            } 
            else if (140 < growth && growth <= 175)
            {
                outputInfo = program.getInfo(heightCategories[1]);
            } 
            else if (175 < growth && growth <= 200)
            {
                outputInfo = program.getInfo(heightCategories[2]);
            }
            else
            {
                outputInfo = program.getInfo(heightCategories[3]);
            }

            Console.WriteLine("\r");
            Console.WriteLine(outputInfo);


        }

        string getInfo (string category)
        {
            return "Your growth category is: " + category;
        }       

    }
}