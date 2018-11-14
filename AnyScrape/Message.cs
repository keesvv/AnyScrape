using System.Drawing;
using Console = Colorful.Console;

namespace AnyScrape
{
    public static class Message
    {
        /// <summary>
        /// Prints an error message.
        /// </summary>
        /// <param name="message">The message to format and print.</param>
        public static void Error(string message)
        {
            Console.WriteLine(string.Format(" [!] {0}", message), Color.Red);
        }

        /// <summary>
        /// Prints an info message.
        /// </summary>
        /// <param name="message">The message to format and print.</param>
        public static void Info(string message)
        {
            Console.WriteLine(string.Format(" [i] {0}", message), Color.DodgerBlue);
        }

        /// <summary>
        /// Prints an success message.
        /// </summary>
        /// <param name="message">The message to format and print.</param>
        public static void Success(string message)
        {
            Console.WriteLine(string.Format(" [-] {0}", message), Color.LawnGreen);
        }
    }
}
