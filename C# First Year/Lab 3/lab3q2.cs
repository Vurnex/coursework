/* 
	
	Laquon Hamilton
	ITS-245
	9/12/20
	Lab 3
	Question 2

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_3
{
	class GuessingGame
	{
		
		static void Main(string[] args)
		{
			Console.Clear(); 

			Console.WriteLine("\nProgram that generates a random number between 1 and 10 and asks the user to guess that number.");

			int userGuess;
			Random ranNumberGenerator = new Random();
			int randomNumber;
			randomNumber = ranNumberGenerator.Next(1, 10);
			string tryAgain = ""; //for asking user to guess again

			Console.Write("\nPlease enter a number between 1 and 10: ");
			userGuess = Convert.ToInt32(Console.ReadLine());

			while (userGuess < 1 || userGuess > 10) //input validation
			{
				Console.WriteLine("\nYou must guess a number between 1 and 10. \n\nPress enter to continue.");

				Console.ReadLine();
				Console.Clear();

				Console.Write("\nPlease enter a number between 1 and 10: ");
				userGuess = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("\nNumber Entered: {0}", userGuess);
			Console.WriteLine("\nNumber Chosen: {0}", randomNumber);

			if (userGuess < randomNumber)
			{
				Console.WriteLine("\nYou guessed too low.");
			}
			else if (userGuess > randomNumber)
			{
				Console.WriteLine("\nYou guessed too high.");
			}
			else if (userGuess == randomNumber)
			{
				Console.WriteLine("\nYou guessed correctly!");
			}

			Console.Write("\nWould you like to try again? (Y/N): ");
			tryAgain = Console.ReadLine();

			while (tryAgain != "Y" && tryAgain != "N") //input validation
			{
				Console.WriteLine("\nYou must enter the character Y or N.");

				Console.Write("\nWould you like to try again? (Y/N): ");
				tryAgain = Console.ReadLine();
			}

			if (tryAgain == "Y")
			{
				GuessingGame.Main(args);
			}
			else if (tryAgain == "N")
			{
				Environment.Exit(0); //exit program
			}

		}

	}
		
}

