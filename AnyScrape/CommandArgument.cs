using System;
using System.Collections.Generic;
using System.Text;

namespace AnyScrape
{
    public class CommandArgument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; }
    }
}
