namespace MovieDatabase
{
    public class Program
    {
		static int userChoice;
		static string genre;
		static bool runAgain = true;
		
		public static void Main()
		{
			Movie m = new Movie("null", "null");
			Movie Shrek = new Movie("Shrek", "Animated");
			Movie Scream = new Movie("Scream", "Horror");
			Movie ShawShankRedemption = new Movie("The Shaw Shank Redemption", "Drama");
			Movie TheFifthElement = new Movie("The Fifth Element", "Sci-Fi");
			Movie Aladin = new Movie("Aladin", "Animated");
			Movie Saw = new Movie("Saw", "Horror");
			Movie TheWolfOfWallStreet = new Movie("The Wolf of Wall Street", "Drama");
			Movie Inception = new Movie("Inception", "Sci-Fi");
			Movie SouthPark = new Movie("South Park Bigger Longer And Uncut", "Animated");
			Movie ForrestGump = new Movie("Forrest Gump", "Drama");
			List<Movie> ourMovies = new List<Movie>() { Aladin, ForrestGump, Inception, Saw, Scream, ShawShankRedemption, Shrek, SouthPark, TheFifthElement, TheWolfOfWallStreet };
			while (runAgain)
			{
				GetGenreChoice();
				m.ShowMovieByType(ourMovies, genre);
				runAgain = RunAgain();
			}
		}
		public static string GetGenreChoice()
        {
			try
			{	
				Console.WriteLine("Please choose a movie Genre.");
				Console.WriteLine("1. Animated");
				Console.WriteLine("2. Horror");
				Console.WriteLine("3. Sci-Fi");
				Console.WriteLine("4. Drama");
				userChoice = int.Parse(Console.ReadLine());

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
            }	return GetGenreChoice();
		}
		public static bool RunAgain()
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