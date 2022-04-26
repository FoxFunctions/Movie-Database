using System;
namespace MovieDatabase
{
	public class Helper
	{
		public string GetGenreChoice()
		{
			try
			{
				Console.WriteLine("Please choose a movie Genre.");
				Console.WriteLine("1. Animated");
				Console.WriteLine("2. Horror");
				Console.WriteLine("3. Sci-Fi");
				Console.WriteLine("4. Drama");
				int userChoice = int.Parse(Console.ReadLine());
				string genre = "";

				if (userChoice <= 0 || userChoice > 4)
				{
					Console.WriteLine("That is not a valid selection. Please enter the number that matches your genre selection");
					return GetGenreChoice();
				}
				else if (userChoice == 1)
				{
					genre = "Animated";
				}
				else if (userChoice == 2)
				{
					genre = "Horror";
				}
				else if (userChoice == 3)
				{
					genre = "Sci-Fi";
				}
				else if (userChoice == 4)
				{
					genre = "Drama";
				}
				return genre;
			}
			catch
			{
				Console.WriteLine("That is not a valid selection. Please enter the number that matches your genre selection");
			}
			return GetGenreChoice();
		}
		public bool RunAgain()
		{
			Console.WriteLine("Would you like to run the program again? Please enter y/n");
			string input = Console.ReadLine().ToLower().Trim();

			if (input == "y")
			{
				return true;
			}
			else if (input == "n")
			{
				return false;
			}
			else
			{
				Console.WriteLine("I didn't quite get that. Please enter y or n");
				return RunAgain();
			}
		}
	}
}

