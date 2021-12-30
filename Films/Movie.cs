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
        public DateTime RelaseDate { get { return relaseDate; } }
        public Genres Genre { get { return genre; } }
        public int Id { get { return _id; } }

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

        public void AddMovie(string _name, Genres _genre, string _releaseDate)
        {

        }
    }
}
