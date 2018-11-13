using System;
using System.Collections.Generic;
using System.Text;

namespace AnyScrape
{
    public class ScrapeOptions
    {
        public string TargetUri { get; set; }
        public string TargetElement { get; set; }
        public string TargetAttribute { get; set; }
        public int MaxItems { get; set; } = 100;
    }
}
