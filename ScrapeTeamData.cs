using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper
{
    public class TeamProgram
    {

        public void controller(string url)
        {

            HtmlDocument html = fetchHTML(url);
            string PF = fetchPointsFor(html);
            string yards = fetchYards(html);
            string passingTD = fetchPassingTD(html);

            if (url == "https://www.pro-football-reference.com/teams/buf/2024.htm")
            {
                Console.WriteLine("Buffalo Bills:");
            }
            else if (url == "https://www.pro-football-reference.com/teams/nwe/2024.htm")
            {
                Console.WriteLine("New England Patriots:");
            }
            else if (url == "https://www.pro-football-reference.com/teams/mia/2024.htm")
            {
                Console.WriteLine("Miami Dolphins:");
            }
            else if (url == "https://www.pro-football-reference.com/teams/nyj/2024.htm")
            {
                Console.WriteLine("New York Jets:");
            }

            display(PF, yards, passingTD);
        }

        public HtmlDocument fetchHTML(String url)
        {
            var httpClient = new HttpClient();
            // import raw html and store into var
            var html = httpClient.GetStringAsync(url).Result;
            // put html into Document object for usage
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            return htmlDocument;

        }

        private string fetchPointsFor(HtmlDocument htmlDocument)
        {
            var PF_Element = htmlDocument.DocumentNode.SelectSingleNode("//*[@id=\"team_stats\"]/tbody/tr[1]/td[1]");
            var PF = PF_Element.InnerText;
            return PF;
        }

        private string fetchYards(HtmlDocument htmlDocument)
        {
            var yards_Element = htmlDocument.DocumentNode.SelectSingleNode("//*[@id=\"team_stats\"]/tbody/tr[1]/td[2]");
            var yards = yards_Element.InnerText;
            return yards;
        }

        private string fetchPassingTD(HtmlDocument htmlDocument)
        {
            var passingTD_Element = htmlDocument.DocumentNode.SelectSingleNode("//*[@id=\"team_stats\"]/tbody/tr[1]/td[11]");
            var passingTD = passingTD_Element.InnerText;
            return passingTD;
        }

        private void display(string PF, string yards, string passingTD)
        {
            Console.WriteLine("Points for: " + PF);
            Console.WriteLine("Total yards: " + yards);
            Console.WriteLine("Passing touchdowns: " + passingTD);
            Console.WriteLine();
        }
    }
}