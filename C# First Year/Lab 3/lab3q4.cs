/* 
	
	Laquon Hamilton
	ITS-245
	9/12/20
	Lab 3
	Question 4

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_245_Lab_3
{
	class CountVowels
	{
		
		static void Main(string[] args)
		{
			Console.Clear();

			Console.WriteLine("\nProgram that gets a phrase from the user and counts how many vowels it has.");

			string newWord;
			int vowels = 0;
			string anotherWord = " ";

			Console.Write("\nEnter a word: ");
			newWord = Console.ReadLine();

			foreach (char c in newWord)
			{
				if (c == 'a' || c == 'e' || c == 'i' || c == 'o'|| c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'U' || c == 'O')
				{
					vowels++;
				}
			}

			Console.WriteLine("\nNumber of vowels: {0}", vowels);
			Console.Write("\nEnter another word? (Y/N): ");
			anotherWord = Console.ReadLine();
			
			while (anotherWord != "Y" && anotherWord != "N")
			{
				Console.WriteLine("\nYou must enter the character Y or N.");
				Console.Write("\nEnter another word? (Y/N): ");
				anotherWord = Console.ReadLine();
			}

			if (anotherWord == "Y")
			{
				CountVowels.Main(args);
			}
			if (anotherWord == "N")
			{
				Environment.Exit(0);
			}

		}

	}
		
}
