﻿using System.Collections.Generic;

namespace SportingSolutions.Udapi.Sdk.Model
{
    public class RestItem
    {
        public RestItem()
        {
            Links = new List<RestLink>();
        }

        public RestItem(string name)
            : this()
        {
            Name = name;
        }

        public string Name { get; set; }
        public Summary Content { get; set; }

        public List<RestLink> Links { get; set; }
    }
}