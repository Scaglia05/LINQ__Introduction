using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    internal class Songs
    {

        #region ctor

        public Songs(int id, string name, string band, DateTime releaseDate)
        {
            Id = id;
            Name = name;
            Band = band;
            ReleaseDate = releaseDate;
        }

        public int Id { get; }
        public string Name { get; }
        public string Band { get; }
        public DateTime ReleaseDate { get; }

        #endregion


        public override string ToString() =>
            $"Code: {Id} | Name: {Name} | Band: {Band} | Release date: {ReleaseDate}";

    }
}
