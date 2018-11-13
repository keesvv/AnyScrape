using System;
using System.Drawing;
using System.Text;
using Console = Colorful.Console;

namespace AnyScrape
{
    public static class Message
    {
        public static void Error(string message)
        {
            Console.WriteLine(string.Format(" [!] {0}", message), Color.Red);
        }

        public static void Info(string message)
        {
            Console.WriteLine(string.Format(" [i] {0}", message), Color.DodgerBlue);
        }

        public static void Success(string message)
        {
            Console.WriteLine(string.Format(" [-] {0}", message), Color.LawnGreen);
        }
    }
}
