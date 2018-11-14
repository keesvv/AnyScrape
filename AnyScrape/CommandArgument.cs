using System;
using System.Collections.Generic;
using System.Text;

namespace AnyScrape
{
    public class CommandArgument
    {
        /// <summary>
        /// The name (or alias) for the command argument.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A short description of the command argument to explain to the user.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Determines if the argument is required.
        /// </summary>
        public bool IsRequired { get; set; }
    }
}
