using System;
using System.Collections.Generic;
using System.Text;

namespace AnyScrape
{
    public class ScrapeOptions
    {
        /// <summary>
        /// The target URI for the <see cref="Scraper"/> to scrape.
        /// </summary>
        public string TargetUri { get; set; }

        /// <summary>
        /// The HTML DOM element for the <see cref="Scraper"/> to look for.
        /// </summary>
        public string TargetElement { get; set; }

        /// <summary>
        /// The HTML DOM attribute to look for inside the <see cref="TargetElement"/>.
        /// </summary>
        public string TargetAttribute { get; set; }

        /// <summary>
        /// The maximum amount of items for the <see cref="Scraper"/> to return.
        /// </summary>
        public int MaxItems { get; set; } = 100;
    }
}
