﻿using System.Collections.Generic;

namespace MarvelSharp.Model
{
    public class Comic : ItemBase
    {
        public Comic()
        {
            Urls = new List<Url>();
            TextObjects = new List<TextObject>();
            Dates = new List<DateItem>();
            Prices = new List<PriceItem>();
        }

        /// <summary>
        /// The ID of the digital comic representation of this comic. Will be 0 if the comic is not available digitally.
        /// </summary>
        public int? DigitalId { get; set; }

        /// <summary>
        /// The canonical title of the comic.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The number of the issue in the series (will generally be 0 for collection formats).
        /// </summary>
        public double? IssueNumber { get; set; }

        /// <summary>
        /// If the issue is a variant (e.g. an alternate cover, second printing, or director’s cut), a text description of the variant.
        /// </summary>
        public string VariantDescription { get; set; }

        /// <summary>
        /// The preferred description of the comic.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The ISBN for the comic (generally only populated for collection formats).
        /// </summary>
        public string Isbn { get; set; }

        /// <summary>
        /// The UPC barcode number for the comic (generally only populated for periodical formats).
        /// </summary>
        public string Upc { get; set; }

        /// <summary>
        /// The Diamond code for the comic.
        /// </summary>
        public string DiamondCode { get; set; }

        /// <summary>
        /// The EAN barcode for the comic.
        /// </summary>
        public string Ean { get; set; }

        /// <summary>
        /// The ISSN barcode for the comic.
        /// </summary>
        public string Issn { get; set; }

        /// <summary>
        /// The publication format of the comic e.g. comic, hardcover, trade paperback.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// The number of story pages in the comic.
        /// </summary>
        public int? PageCount { get; set; }

        /// <summary>
        /// A set of descriptive text blurbs for the comic.
        /// </summary>
        public List<TextObject> TextObjects { get; set; }

        /// <summary>
        /// A set of public web site URLs for the resource.
        /// </summary>
        public List<Url> Urls { get; set; }

        /// <summary>
        /// A summary representation of the series to which this comic belongs.
        /// </summary>
        public ItemSummary Series { get; set; }

        /// <summary>
        /// A list of variant issues for this comic (includes the "original" issue if the current issue is a variant).
        /// </summary>
        public List<ItemSummary> Variants { get; set; }

        /// <summary>
        /// A list of collections which include this comic (will generally be empty if the comic's format is a collection).
        /// </summary>
        public List<ItemSummary> Collections { get; set; }

        /// <summary>
        /// A list of issues collected in this comic (will generally be empty for periodical formats such as "comic" or "magazine").
        /// </summary>
        public List<ItemSummary> CollectedIssues { get; set; }

        /// <summary>
        /// A list of key dates for this comic.
        /// </summary>
        public List<DateItem> Dates { get; set; }

        /// <summary>
        /// A list of prices for this comic.
        /// </summary>
        public List<PriceItem> Prices { get; set; }

        /// <summary>
        /// A list of promotional images associated with this comic.
        /// </summary>
        public List<Image> Images { get; set; }

        /// <summary>
        /// A resource list containing the creators associated with this comic.
        /// </summary>
        public ItemCollection Creators { get; set; }

        /// <summary>
        /// A resource list containing the characters which appear in this comic.
        /// </summary>
        public ItemCollection Characters { get; set; }

        /// <summary>
        /// A resource list containing the stories which appear in this comic.
        /// </summary>
        public ItemCollection Stories { get; set; }

        /// <summary>
        /// A resource list containing the events in which this comic appears.
        /// </summary>
        public ItemCollection Events { get; set; }

        /// <summary>
        /// Returns a string identifying the Comic object
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Title;
    }
}
