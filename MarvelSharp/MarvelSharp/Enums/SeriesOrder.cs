﻿using MarvelSharp.Attributes;

namespace MarvelSharp.Enums
{
    public enum SeriesOrder
    {
        [StringValue("title")]
        TitleAscending,
        [StringValue("modified")]
        ModifiedAscending,
        [StringValue("startYear")]
        StartYearAscending,
        [StringValue("-title")]
        TitleDescending,
        [StringValue("-modified")]
        ModifiedDescending,
        [StringValue("-startYear")]
        StartYearDescending
    }
}
