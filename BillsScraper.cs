using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper
{
    class Program
    {
        static void Main(String[] args)
        {
            // send get request to bills stat page
            String url = "https://www.pro-football-reference.com/teams/buf/2024.htm";
            var httpClient = new HttpClient();
            // import raw html and store into var
            var html = httpClient.GetStringAsync(url).Result;
            // put html into Document object for usage
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // get team stats using the xPath for that line of the table
            var PF_Element = htmlDocument.DocumentNode.SelectSingleNode("//*[@id=\"team_stats\"]/tbody/tr[1]/td[1]");
            var yards_Element = htmlDocument.DocumentNode.SelectSingleNode("//*[@id=\"team_stats\"]/tbody/tr[1]/td[2]");
            var passingTD_Element = htmlDocument.DocumentNode.SelectSingleNode("//*[@id=\"team_stats\"]/tbody/tr[1]/td[11]");

            var PF = PF_Element.InnerText;
            var yards = yards_Element.InnerText;
            var passingTD = passingTD_Element.InnerText;

            Console.WriteLine("Points for: " + PF);
            Console.WriteLine("Total yards: " + yards);
            Console.WriteLine("Number passing touchdowns: " + passingTD);

        }
    }
}