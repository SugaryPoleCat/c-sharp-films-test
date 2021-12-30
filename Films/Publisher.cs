namespace Films
{
    internal class Publisher
    {
        private string name;
        private string? description;
        private int _id;
        static int _count = 0;

        /// <summary>
        /// Returns name as string
        /// </summary>
        public string Name { get { return name; } }
        /// <summary>
        /// returns description as string
        /// </summary>
        public string Description { get { return description; } }
        /// <summary>
        /// returns id as int
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// returns cout as int
        /// </summary>
        public static int Count { get { return _count; } }

        /// <summary>
        /// Handles the ID and count
        /// </summary>
        private Publisher()
        {
            _count++;
            this._id = _count;
        }

        /// <summary>
        /// Constructs a new publisher with name
        /// </summary>
        /// <param name="_name">The name of the publisher</param>
        public Publisher(string _name) : this()
        {
            this.name = _name;
        }

        /// <summary>
        /// Constructs a new publisher with name and description
        /// </summary>
        /// <param name="_name">The name of the publisher</param>
        /// <param name="_description">escription of the publisher</param>
        public Publisher(string _name, string _description) : this()
        {
            this.name = _name;
            this.description = _description;
        }
    }
}
