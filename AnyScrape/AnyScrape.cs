using System;
using System.Linq;
using System.Text;
using Console = Colorful.Console;

namespace AnyScrape
{
    public static class AnyScrape
    {
        /// <summary>
        /// Handles user input, returned by a prompt.
        /// </summary>
        /// <param name="input">The user input from the prompt to handle.</param>
        public static void HandleInput(string input)
        {
            string[] rawCommands = Helper.AvailableCommands.Select(i => i.Name).ToArray();
            string[] arguments = input.Split(' ');
            string command = arguments[0];
            arguments = arguments.Skip(1).ToArray();

            if (!rawCommands.Contains(command) && !string.IsNullOrWhiteSpace(input))
            {
                Message.Error("Sorry, that command does not exist.");
                return;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var commandArguments = Helper.AvailableCommands.First(i => i.Name == command).Arguments;
            var requiredArguments = commandArguments.Where(i => i.IsRequired).ToArray();

            if (arguments.Length < requiredArguments.Length)
            {
                Message.Error("You have entered an invalid number of arguments.");
                return;
            }

            if (command == "help")
            {
                Helper.PrintSyntax();
            }
            else if (command == "scrape")
            {
                Scraper.Scrape(arguments[0]);
            }
            else if (command == "exit")
            {
                Helper.Exit();
            }
        }

        /// <summary>
        /// Main entry point of AnyScrape.
        /// </summary>
        /// <param name="args">The application arguments.</param>
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CancelKeyPress += (o, ev) => Helper.Exit();

            Helper.PrintAbout();
            Helper.PrintHint();

            while (true)
            {
                string input = Helper.Prompt();
                HandleInput(input);
            }
        }
    }
}
