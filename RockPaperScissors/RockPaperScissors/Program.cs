using System;
using System.Formats.Asn1;
using System.Linq;


class RockPaperScissors{

public static void Main(string[] args) // Rock Paper Scissors, Bow Target Arrow 
{

    Console.WriteLine("\t\t\tWelcome to Bow Target Arrow!");
    Console.WriteLine("\t\tThe rules are just like Rock Paper Scissors.");
    Console.WriteLine("\tBow beats Arrow, Arrow beats Target, and Target beats Bow.");
    Random rnd = new Random();

    while (true)
    {
        Console.WriteLine("\n\t    Please select your weapon: Bow, Target, or Arrow");
        // Bow == Rock | Target == Paper | Arrow == Scissors
        string? playerChoice = Console.ReadLine();

        if (!string.IsNullOrEmpty(playerChoice)) // if empty
        {
            // playerChoice capitalizes the first letter
            playerChoice = char.ToUpper(playerChoice[0]) + playerChoice.Substring(1).ToLower();

            string[] btaChoices = { "Bow", "Target", "Arrow" };

            if (playerChoice == "Quit"){ // Dev Quit
                Console.WriteLine("See you next time!");
                break;
            }
            else if (!btaChoices.Contains(playerChoice))
            {
                Console.WriteLine("Invalid choice, please choose from Bow, Target or Arrow.");
                continue;
            }

            string computerChoice = btaChoices[rnd.Next(btaChoices.Length)];
			
			Console.WriteLine("\n-------------------------");
			Console.WriteLine($"Player picks {playerChoice}!");
			
			Thread.Sleep(1000);
            Console.WriteLine($"Computer picks {computerChoice}!");
			Console.WriteLine("-------------------------");

			Thread.Sleep(1000);

            if (playerChoice == computerChoice)
            {
                Console.WriteLine("Tie!");
            }
            // Arrow beats Target, Target beats Bow, Bow beats Arrow
            else if ((playerChoice == "Bow" && computerChoice == "Arrow") ||
                     (playerChoice == "Arrow" && computerChoice == "Target") ||
                     (playerChoice == "Target" && computerChoice == "Bow"))
            {
                Console.WriteLine("Player wins!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }

            Console.WriteLine("Would you like to play again? (y/n)");
            char continueGame = char.ToLower(Console.ReadKey().KeyChar);

            if (continueGame == 'n')
            {
                //MainMenu();
                Console.WriteLine("See you next time!");
				break;
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid choice.");
        }
    	
		}
	}
}