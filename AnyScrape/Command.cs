using System;

namespace AnyScrape
{
    public class Command
    {
        /// <summary>
        /// The name (or alias) for the command to be recognized.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the command to explain to the user.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The list of <see cref="CommandArgument"/>s for this command.
        /// </summary>
        public CommandArgument[] Arguments { get; set; } = new CommandArgument[] { };
    }
}
