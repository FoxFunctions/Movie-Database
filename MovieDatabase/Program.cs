namespace MovieDatabase
{
    public class Program
    {
		static bool runAgain = true;
		public static void Main()
		{
			Helper h = new Helper();
			Movie m = new Movie("", "");
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
			List<Movie> ourMovies = new List<Movie>() { Aladin, ForrestGump, Inception, Saw, Scream, ShawShankRedemption, Shrek, SouthPark, TheFifthElement, TheWolfOfWallStreet  };

			while (runAgain)
			{
				m.ShowMovieByType(ourMovies, h.GetGenreChoice());
				runAgain = h.RunAgain();
			}
		}
	} 
}