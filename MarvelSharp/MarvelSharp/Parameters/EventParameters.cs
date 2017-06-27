﻿using MarvelSharp.Enums;
using MarvelSharp.Model;
using System;
using System.Collections.Generic;

namespace MarvelSharp.Parameters
{
    public class EventParameters : ParametersBase
    {
        public EventParameters()
        {
            Comics = new List<int>();
            Series = new List<int>();
            Stories = new List<int>();
        }

        public string Name { get; set; }
        public string NameStartsWith { get; set; }
        public DateTime? ModifiedSince { get; set; }
        public List<int> Creators { get; set; }
        public List<int> Series { get; set; }
        public List<int> Comics { get; set; }
        public List<int> Stories { get; set; }
        public EventOrder? OrderBy { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
    }
}