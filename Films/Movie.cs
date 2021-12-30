namespace Films
{
    /// <summary>
    /// Comedy, Action, Thriller
    /// </summary>
    enum Genres { Comedy, Action, Thriller };
    /// <summary>
    /// The movie class
    /// </summary>
    internal class Movie
    {
        private string name;
        private DateTime relaseDate;
        private Genres genre;
        private int _id;
        private static int _count = 0;

        /// <summary>
        /// Show just the name
        /// </summary>
        public string Name { get { return name; } }
        /// <summary>
        /// retruns release date as datetime
        /// </summary>
        public DateTime RelaseDate { get { return relaseDate; } }
        /// <summary>
        /// returns genre as enum
        /// </summary>
        public Genres Genre { get { return genre; } }
        /// <summary>
        /// returns id as int
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// returns count as int
        /// </summary>
        public static int Count { get { return _count;} }

        /// <summary>
        /// This just does ID and counting on each new construct.
        /// </summary>
        private Movie()
        {
            _count++;
            this._id = _count;
        }

        /// <summary>
        /// Constructs a new movie
        /// </summary>
        /// <param name="_name">The movie name</param>
        /// <param name="_genre">The genre of the movie</param>
        /// <param name="_releaseDate">The string in dd-MM-yyyy</param>
        /// <exception cref="ArgumentException">If bad date is parsed</exception>
        public Movie(string _name, Genres _genre, string _releaseDate) : this()
        {
            this.name = _name;
            //this.relaseDate = _releaseDate;
            if (!DateTime.TryParseExact(_releaseDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime _date))
            {
                throw new ArgumentException("Bad date format");
            }
            this.relaseDate = _date;
            this.genre = _genre;
        }

        /// <summary>
        /// This will add a movie, thhough it would be better in movies collection, since it doesnt work CLASS.AddMovie, but CONSTRUCTEDMOVIE.AddMovie, tthats whay it should be used in a collection instead.
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_genre"></param>
        /// <param name="_releaseDate"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AddMovie(string _name, Genres _genre, string _releaseDate)
        {
            _count++;
            _id = _count;
            this.name = _name;
            this.genre = _genre;
            if (!DateTime.TryParseExact(_releaseDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime _date))
            {
                throw new ArgumentException("Bad date format");
            }
            this.relaseDate = _date;
        }
    }
}
