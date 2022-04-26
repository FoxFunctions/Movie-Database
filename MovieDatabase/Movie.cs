namespace MovieDatabase
{
	public class Movie
	{
		public string MovieTitle { get; set; }
		public string MovieCategory { get; set; }

		public Movie(string movieTitle, string MovieCategory)
		{
			this.MovieTitle = movieTitle;
			this.MovieCategory = MovieCategory;
		}

		public void ShowMovieByType(List<Movie> movies, string category)
        {
            Console.WriteLine($"Here is a list of our {category} films.");
                
			for (int i = 0; i <= movies.Count -1;  i++)
            {
				if (category == "Drama")
				{
					if (movies[i].MovieCategory == category)
					{
						Console.WriteLine(movies[i].MovieTitle);
					}
				}
				else if (category == "Animated")
				{
					if (movies[i].MovieCategory == "Animated")
					{
						Console.WriteLine(movies[i].MovieTitle);
					}
				}
				else if (category == "Horror")
                {
					if (movies[i].MovieCategory == "Horror")
					{
						Console.WriteLine(movies[i].MovieTitle);
					}
                }
				else if (category == "Sci-Fi")

                {	if (movies[i].MovieCategory == "Sci-Fi")
					{
						Console.WriteLine(movies[i].MovieTitle);
					}
                }
                else
                {
                    Console.WriteLine("We do not have any films of that genre.");
					break;
                }
			}
        }
	}
}

