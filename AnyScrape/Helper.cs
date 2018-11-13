using System;
using System.Drawing;
using System.Linq;
using System.Text;
using Console = Colorful.Console;

namespace AnyScrape
{
    public static class Helper
    {
        public static Command[] AvailableCommands =
        {
            new Command()
            {
                Name = "help",
                Description = "Displays this screen."
            },

            new Command()
            {
                Name = "scrape",
                Description = "Scrapes the contents of a specified URL.",
                Arguments = new CommandArgument[]
                {
                    new CommandArgument()
                    {
                        Name = "url",
                        Description = "The URL of the web page to scrape the contents of.",
                        IsRequired = true
                    }
                }
            },

            new Command()
            {
                Name = "exit",
                Description = "Exits AnyScrape. Bye bye!"
            }
        };

        public static string Prompt(string prompt = "→", Color? color = null)
        {
            if (color == null)
                color = Color.Coral;

            Console.Write(string.Format(" {0} ", prompt), color.Value);
            return Console.ReadLine();
        }

        public static void PrintAbout()
        {
            string[] about = {
                "Welcome to AnyScrape!",
                "This tool was created by @keesvv",
                "Licensed under MIT. Have fun!"
            };

            var maxLineLength = about.OrderByDescending(i => i.Length).First().Length;
            var border = " " + new string('—', maxLineLength + 1);

            Console.WriteLine(border);

            foreach (var line in about)
            {
                Console.WriteLine(" " + line, Color.Cyan);
            }

            Console.WriteLine(border);
        }

        public static void PrintHint()
        {
            Console.WriteLineFormatted(
                " Type {0} to view a list of available commands.\n" +
                " If you want to quit, type {1} at any times.",
                Color.Yellow, Color.Coral, "help", "exit"
                );
            Console.WriteLine();
        }

        public static void PrintSyntax()
        {
            var border = new string('—', Console.BufferWidth - 2);

            foreach (var item in AvailableCommands)
            {
                StringBuilder builder = new StringBuilder();

                foreach (var arg in item.Arguments)
                {
                    if (arg.IsRequired)
                    {
                        builder.AppendFormat("<{0}> ", arg.Name);
                    }
                    else
                    {
                        builder.AppendFormat("[{0}] ", arg.Name);
                    }
                }

                Console.WriteLine(" " + border, Color.Coral);
                Console.WriteLine(
                    string.Format(" {0} {1}", item.Name, builder.ToString()), Color.Yellow
                    );

                Console.WriteLine(" " + item.Description, Color.Coral);
            }

            Console.WriteLine(" " + border, Color.Coral);
        }

        public static void Exit(int code = 0)
        {
            Console.ReplaceAllColorsWithDefaults();
            Environment.Exit(code);
        }
    }
}
