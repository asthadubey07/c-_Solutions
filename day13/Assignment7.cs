using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Movie
{

    public class Movie
    {
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public string? Director { get; set; }
        public string? ReleaseDate { get; set; }
        public string? HeroName { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>()
            {
            new Movie{MovieId= 100, MovieName = "RRR", Director = "rajamoli",ReleaseDate = "11/12/12", HeroName = "JN.NTR" },
            new Movie{MovieId= 200, MovieName = "KJF", Director = "Rajamoli",ReleaseDate = "11/10/12", HeroName = "rocky" },
            new Movie{MovieId= 300, MovieName = "KJF2", Director = "Rajamoli",ReleaseDate = "11/9/12", HeroName = "rocky" },
            new Movie{MovieId= 400, MovieName = "KKKG", Director = "karanjohar",ReleaseDate = "11/8/12", HeroName = "SRK"},
            new Movie{MovieId= 500, MovieName = "DDLJ", Director = "karan",ReleaseDate = "11/1/12", HeroName = "SRK" },

            };
            var query1 = from movie in MovieList
                         select movie;
            System.Console.WriteLine("All Movies are:");
            foreach (var item in query1)
            {
                Console.WriteLine("MovieID Is: {0}\nMovieName Is:{1}\nDirector of Movie:{2}\nReleaseDate of Movie :{3}\nHeroName of Movie Is :{4}\n\n ", item.MovieId, item.MovieName, item.Director, item.ReleaseDate, item.HeroName);
            }

            var query2 = from movie in MovieList
                         select movie.MovieName;
            System.Console.WriteLine("All Movies Name are:");
            foreach (var item in query2)
            {
                Console.WriteLine("\nMovieName Is:{0}\n\n", item);
            }



            var query3 = from movie in MovieList
                         select new { movie.MovieName, movie.HeroName };
            System.Console.WriteLine("All Movies And Hero Names Are:");
            foreach (var item in query3)
            {
                Console.WriteLine("\nMovieName Is:{0}\nHeroName of Movie Is :{1}\n", item.MovieName, item.HeroName);
            }





             var query4 = from movie in MovieList
                         select new { movie.MovieName, movie.Director };
            System.Console.WriteLine("All Movies belogns to directord Are:");
            var DirectorName = "rajamoli";
            var MovieByDirector = MovieList.Where(item => item.Director == DirectorName);
            foreach (var item in MovieByDirector)
            {
               
                Console.WriteLine("\nMovieName Is:{0}\nDirector of Movie Is :{1}\n", item.MovieName, item.Director);
            }

            


             var query5 = from movie in MovieList
                         select new { movie.MovieName, movie.HeroName };
            System.Console.WriteLine("All Movies based on Hero Names Are:");
            var Hero = "SRK";
            var MovieByHero = MovieList.Where(item => item.HeroName == Hero);
            foreach (var item in MovieByHero)
            {
               
                Console.WriteLine("\nMovieName Is:{0}\nHeroName of Movie Is :{1}\n", item.MovieName, item.HeroName);
            }





 var query6 = from movie in MovieList
                         select new { movie.MovieName, movie.ReleaseDate };
            System.Console.WriteLine("All Movies based on Hero Names Are:");
            var Release = "month of july";
            var MovieByMonth = MovieList.Where(item => item.HeroName == Release);
            foreach (var item in MovieByMonth)
            {
               
                Console.WriteLine("\nMovieName Is:{0}\nHeroName of Movie Is :{1}\n", item.MovieName, item.ReleaseDate);
            }

        }
    }
}

