namespace Films
{
    enum Genders { F, M };
    internal class Director
    {
        private string firstName;
        private string lastName;
        private int _id;
        private Genders gender;
        static int _count = 0;

        /// <summary>
        /// Returns first name
        /// </summary>
        public string FirstName { get { return firstName; } }
        /// <summary>
        /// Return last name
        /// </summary>
        public string LastName { get { return lastName; } }
        /// <summary>
        /// Returns gender enum thing.
        /// </summary>
        public Genders Gender { get { return gender; } }
        /// <summary>
        /// Returns ID as int.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// returns ID as formatted.
        /// THIS IS NOT NECESSARY
        /// </summary>
        public string IdFormat
        {
            get
            {
                string formattedID = _id.ToString();
                formattedID = formattedID.PadLeft(4, '0');
                return formattedID;
            }
        }

        /// <summary>
        /// This sets a new count and id.
        /// </summary>
        public Director()
        {
            _count++;
            this._id = _count;
        }

        /// <summary>
        /// Director constructor
        /// </summary>
        /// <param name="_fName">First name</param>
        /// <param name="_lName">OLast name</param>
        public Director(string _fName, string _lName)
        {
            this.firstName = _fName;
            this.lastName = _lName;
        }
    }
}
