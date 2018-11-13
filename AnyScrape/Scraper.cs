using System;
using System.Net;
using System.Drawing;
using AngleSharp.Parser.Html;
using System.Linq;

namespace AnyScrape
{
    public static class Scraper
    {
        public static void Scrape(string url)
        {
            Color promptColor = Color.Yellow;
            WebClient cacheClient = new WebClient();
            HtmlParser parser = new HtmlParser();

            ScrapeOptions options = new ScrapeOptions()
            {
                TargetUri = url
            };

            string source;
            bool isValid = Uri.TryCreate(url, UriKind.Absolute, out var result)
                && (result.Scheme == Uri.UriSchemeHttp
                || result.Scheme == Uri.UriSchemeHttps);

            if (!isValid)
            {
                Message.Error("The URL you entered is invalid.");
                return;
            }

            options.TargetElement = Helper.Prompt(prompt: "Target element:", color: promptColor);
            options.TargetAttribute = Helper.Prompt(prompt: "Target attribute:", color: promptColor);
            options.MaxItems = int.Parse(Helper.Prompt(prompt: "Max items [default=100]:", color: promptColor));

            Message.Info("Starting web scraper...");
            Message.Info("Caching page source...");

            source = cacheClient.DownloadString(options.TargetUri);
            var document = parser.Parse(source);
            var query = document.QuerySelectorAll(options.TargetElement).Take(options.MaxItems);

            foreach (var element in query)
            {
                WebClient client = new WebClient();
                string fileName = string.Format("scrape-" + new Random().Next(1, int.MaxValue)) + ".png";
                var attrValue = element.GetAttribute(options.TargetAttribute);

                client.DownloadFile(attrValue, fileName);
                Message.Success(string.Format("Downloaded {0}", fileName));
            }
        }
    }
}
