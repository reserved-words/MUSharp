﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelSharp.Model
{
    public class Comic
    {
        public Comic()
        {
            Urls = new List<Url>();
            TextObjects = new List<ComicTextObject>();
            Dates = new List<DateItem>();
            Prices = new List<PriceItem>();
        }

        public int? Id { get; set; }
        public int? DigitalId { get; set; }
        public string Title { get; set; }
        public double? IssueNumber { get; set; }
        public string VariantDescription { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public string Isbn { get; set; }
        public string Upc { get; set; }
        public string DiamondCode { get; set; }
        public string Ean { get; set; }
        public string Issn { get; set; }
        public string Format { get; set; }
        public int? PageCount { get; set; }
        public List<ComicTextObject> TextObjects { get; set; }
        public string ResourceUri { get; set; }
        public List<Url> Urls { get; set; }
        public Item Series { get; set; }
        public List<Item> Variants { get; set; }
        public List<Item> Collections { get; set; }
        public List<Item> CollectedIssues { get; set; }
        public List<DateItem> Dates { get; set; }
        public List<PriceItem> Prices { get; set; }
        public Image Thumbnail { get; set; }
        public List<Image> Images { get; set; }
        public ItemCollection Creators { get; set; }
        public ItemCollection Characters { get; set; }
        public ItemCollection Stories { get; set; }
        public ItemCollection Events { get; set; }

    }
}