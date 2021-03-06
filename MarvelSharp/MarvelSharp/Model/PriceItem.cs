﻿
namespace MarvelSharp.Model
{
    public class PriceItem
    {
        /// <summary>
        /// A description of the price (e.g. print price, digital price).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The price (all prices in USD).
        /// </summary>
        public decimal Price { get; set; }
    }
}
