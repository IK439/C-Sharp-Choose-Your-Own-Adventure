using System;
// This program runs a simple text-based "Choose Your Own Adventure" game using user input and branching logic.

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Choose Your Own Adventure...");

            Console.Write("\nWhat is your name?: ");

            // Using null-coalescing to avoid possible null reference
            string name = Console.ReadLine() ?? "Player";
            
            Console.WriteLine($"\nWelcome, {name}. Your distress signal has been received.");

            Console.WriteLine("\nYou awaken alone aboard a drifting space station. Red emergency lights flicker.");
            Console.WriteLine("Something metallic scrapes slowly outside your cabin door.");
            Console.WriteLine("\nDo you leave your cabin to investigate?");

            string noiseChoice;
            // Repeats prompt until valid user input is provided
            do
            {
                Console.Write("Type YES or NO: ");
                // Null-safe input handling
                noiseChoice = (Console.ReadLine() ?? "").ToUpper();
            }
            while (noiseChoice != "YES" && noiseChoice != "NO");

            if (noiseChoice == "NO")
            {
                Console.WriteLine("\nYou stay inside, clutching the door controls.");
                Console.WriteLine("The scraping grows louder... then suddenly stops.");
                EndStory(); // Call function for end of story text
                return;
            }

            Console.WriteLine("\nThe hallway is empty, but a maintenance hatch glows faintly at the far end.");
            Console.WriteLine("\nDo you OPEN the hatch or KNOCK on it?");

            string doorChoice;
            // Repeats prompt until valid user input is provided
            do
            {
                Console.Write("Type OPEN or KNOCK: ");
                // Null-safe input handling
                doorChoice = (Console.ReadLine() ?? "").ToUpper();
            }
            while (doorChoice != "OPEN" && doorChoice != "KNOCK");

            if (doorChoice == "KNOCK")
            {
                Console.WriteLine("\nA distorted voice crackles through the intercom:");
                Console.WriteLine("\"I am taken from a mine and shut inside a wooden case. I am never released, yet I am used by almost every person. What am I?\"");

                Console.Write("\nType your answer: ");
                string riddleAnswer = (Console.ReadLine() ?? "").Trim().ToUpper();

                // Allow slightly correct answers
                if (riddleAnswer.Contains("GRAPHITE") || riddleAnswer.Contains("PENCIL"))
                {
                    Console.WriteLine("\nThe hatch slides open.");
                    Console.WriteLine("Inside is nothing—except a warm handprint forming on the wall.");
                    Console.WriteLine("You run back to your cabin and seal it shut.");
                }
                else
                {
                    Console.WriteLine("\nSilence.");
                    Console.WriteLine("Something breathes behind the metal.");
                }

                EndStory(); // Call function for end of story text
            }
            else
            {
                Console.WriteLine("\nThe hatch is locked. Your suit interface displays three access codes.");

                string keyChoice;
                // Repeats prompt until valid user input is provided
                do
                {
                    Console.Write("Enter a number between (1-3): ");
                    keyChoice = Console.ReadLine() ?? "";
                }
                while (keyChoice != "1" && keyChoice != "2" && keyChoice != "3");

                // Switch case for different key options
                switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine("\nThe hatch opens.");
                        Console.WriteLine("The room is empty... but your reflection lags behind your movements.");
                        break;
                    case "2":
                        Console.WriteLine("\nAccess denied. Something scratches from inside the walls.");
                        break;
                    case "3":
                        Console.WriteLine("\nAccess denied. The lights go out.");
                        break;
                }

                EndStory(); // Call function for end of story text
            }
        }

        // Displays the ending message for the story
        static void EndStory()
        {
            Console.WriteLine("\nSIGNAL LOST.");
            Console.WriteLine("THE END.");
        }
    }
}