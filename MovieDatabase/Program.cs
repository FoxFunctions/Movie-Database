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
			List<Movie> ourMovies = new List<Movie>() { Aladin, ForrestGump, Inception, Saw, Scream, ShawShankRedemption, Shrek, SouthPark,TheFifthElement, TheWolfOfWallStreet };
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


/* Task: List movies by category.

What will the application do?
The application stores a list of 10 movies and displays them by category.
The user can enter any of the following categories to display the films in the list that match the category: animated, drama, horror, scifi.
After the list is displayed, the user is asked if he or she wants to continue. If no, the program ends.

Build Specifications:
Build a Movie class with two private fields: title and category. Both of these fields should be strings. The class should also provide a constructor that accepts a title and category as parameters and uses the values passed in to initialize the fields.
Class has proper fields of correct type—1 point total
Class has properties for each field—1 point total
Class has constructor—1 point
In your Main, create a List<Movie> and store at least 10 movies there. You can use literals to construct the movies. Make sure to have a mixture of categories.
Program constructs list properly—1 point
Program puts at least 10 properly instantiated Movies into the List—1 point
When the user enters a category, the program should read through all of the movies in the List and display a line for any movie whose category matches the category entered by the user.
Program takes user input correctly—1 point
Program gives explicit feedback if user enters invalid category—1 point
Program iterates through List validly—1 point
Program only outputs if movie matches category—1 point
Program loops if user wants to continue.
Program loops back to ask category again based on user input—1 point

Hints:
Don’t overthink this! Think about how you would do this in real life if you work at a video store, and you have a stack of movies and somebody wants to see which movies in that stack belong to a particular category. When one customer asks for a list of movies, how many times do you loop through the stack of movies?

Extra Challenges:
Standardize the category codes by displaying a menu of categories and having the user select the category by number rather than entering the name.
Display the movies for the selected category in alphabetical order.
Expand the information in your Movie class—run time in minutes, year released, etc. Display the additional information when listing movies.*/