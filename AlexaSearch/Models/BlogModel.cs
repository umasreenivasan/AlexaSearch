using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexaSearch.Models

{
    public class BlogModel
    {
        public string BlogSImage { get; set; }
        public string Category { get; set; }
        public string BlogTitle { get; set; }
        public string date { get; set; }
        public string ShortDesc { get; set; }
        public string Readonbtn { get; set; }
        public string BlogURL { get; set; }
        public Item sitecoreItem { get; set; }
    }
}