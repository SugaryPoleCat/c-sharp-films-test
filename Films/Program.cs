namespace Films
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie = new Movie("Coocoo", Genres.Comedy, "20-09-1993");
            Console.WriteLine(movie.Name);
            Console.WriteLine(movie.Genre);


            var movies = new Movies();

            movies.AddMovie("Koko", "this movie is about a person", "20-09-1993");
            Console.WriteLine(movies.ToString());
            Console.ReadKey();
        }
    }
}