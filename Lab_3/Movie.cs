using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    enum genres
    {
        SciFi = 1,
        Action = 2,
        Horror = 3,
        Fantasy = 4,
        Romance = 5
    }
    class Movie
    {
        public int movieNum;
        public string movieName;
        public int movieDate;
        public genres movieGenre;
        public int movieViews;
        public int movieLikes;

        
        public Movie()
        {
            Console.WriteLine("Input movie information with spaces (Number, Name, Year, Genre, Views, Likes): ");
            Console.WriteLine("If movie name has 2 parts use underscore please");
            string input = Console.ReadLine();

            string[] splitedInput= input.Split(' ');

            if(splitedInput.Length == 6)
            {
                movieNum = Convert.ToInt32(splitedInput[0]);
                movieName = splitedInput[1];
                movieDate = Convert.ToInt32(splitedInput[2]);
                movieGenre = (genres)Convert.ToInt32(splitedInput[3]);
                movieViews = Convert.ToInt32(splitedInput[4]);
                movieLikes = Convert.ToInt32(splitedInput[5]);
            }
            else
            {
                Console.WriteLine("Missing information");
            }
        }
        public double Rating()
        {
            double movieRating = Math.Sqrt(Math.Pow(movieLikes, 2) / movieViews);
            return movieRating;
        }
        public override string ToString()
        {
            return string.Format("{0, 4} {1, -15} {2, -8} {3, -12} {4, 8:0.000}",
                movieNum, movieName, "(" + movieDate + ")", movieGenre, Rating());
        }
    }
}
