using System;
using System.Collections.Generic;
using System.Text;

namespace AnyScrape
{
    public class Command
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CommandArgument[] Arguments { get; set; } = new CommandArgument[] { };
    }
}
