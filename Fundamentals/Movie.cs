using System;
namespace Fundamentals
{
	public class Movie
	{
		private string title;
        private string director;
        private double rating;

		public Movie(string aTitle, string aDirector, double aRating)
		{
			title = aTitle;
			director = aDirector;
			rating = aRating;

		}

		public double Rating
		{
			get { return rating; }
			set {
				if(value  >= 1 && value <= 5)
				{
					rating = value;
				}
				else
				{
					rating = -1.0;
				}
			}

		}
	}
}

