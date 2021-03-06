using System.Collections.Generic;

namespace MarvelSharp.Criteria
{
    /// <summary>
    /// A class representing criteria by which to filter series.
    /// </summary>
    public class SeriesCriteria : BaseCriteria
    {
        /// <summary>
        /// Initializes an instance of the SeriesCriteria class
        /// </summary>
        public SeriesCriteria()
        {
            Comics = new List<int>();
            Characters = new List<int>();
            Events = new List<int>();
            Stories = new List<int>();
            Creators = new List<int>();
            Contains = new List<Format>();
            OrderBy = new List<SeriesOrder>();
        }


        /// <summary>
        /// Return only series matching the specified title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Return series with titles that begin with the specified string (e.g. Sp).
        /// </summary>
        public string TitleStartsWith { get; set; }

        /// <summary>
        /// Return only series matching the specified start year.
        /// </summary>
        public int? StartYear { get; set; }

        /// <summary>
        /// Return only series which feature characters specified by a list of IDs.
        /// </summary>
        public List<int> Characters { get; set; }

        /// <summary>
        /// Return only series which contain comics specified by a list of IDs.
        /// </summary>
        public List<int> Comics { get; set; }

        /// <summary>
        /// Return only series which feature work by creators specified by a list of IDs.
        /// </summary>
        public List<int> Creators { get; set; }

        /// <summary>
        /// Return only series which have comics that take place during events specified by a list of IDs.
        /// </summary>
        public List<int> Events { get; set; }

        /// <summary>
        /// Return only series which contain stories specified by a list of IDs.
        /// </summary>
        public List<int> Stories { get; set; }

        /// <summary>
        /// Filter the series by publication frequency type.
        /// </summary>
        public SeriesType? SeriesType { get; set; }

        /// <summary>
        /// Return only series containing one or more comics with the specified format(s).
        /// </summary>
        public List<Format> Contains { get; set; }

        /// <summary>
        /// Order the result set by the selected fields. Multiple values are given priority in the order in which they are passed.
        /// </summary>
        public List<SeriesOrder> OrderBy { get; set; }
    }
}
