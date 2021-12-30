using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    /// <summary>
    /// would probably be more better with a static class, perhaps.
    /// </summary>
    internal class Movies
    {
        private string name;
        private string description;
        private DateTime relaseDate;
        private int _id;
        static int _count;

        public Movies()
        {
            _count = 0;
        }

        public void AddMovie(string _name, string _description, string _releaseDate)
        {
            if(!DateTime.TryParseExact(_releaseDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out relaseDate))
            {
                throw new ArgumentException("Date time format wrong");
            }
            this.name = _name;
            this.description = _description;
            _count++;
            this._id = _count;
        }

        public override string ToString()
        {
            return $"{this._id}\n{this.name}\n{this.description}\nRelease Date: {relaseDate}";
        }
    }
}
