using HtmlAgilityPack;
using System;
using System.Net.Http;
using utilities;

namespace WebScraper
{
    public class TeamProgram
    {

        public void controllerAFCEast(string url)
        {
            myUtilities myUtil = new myUtilities();
            HtmlDocument html = myUtil.fetchHTML(url);
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

        public void controllerAFCSouth(string url)
        {
            myUtilities myUtil = new myUtilities();
            HtmlDocument html = myUtil.fetchHTML(url);
            string PF = fetchPointsFor(html);
            string yards = fetchYards(html);
            string passingTD = fetchPassingTD(html);

            if (url == "https://www.pro-football-reference.com/teams/htx/2024.htm")
            {
                Console.WriteLine("Houston Texans:");
            }
            else if (url == "https://www.pro-football-reference.com/teams/clt/2024.htm")
            {
                Console.WriteLine("Indianapolis Colts:");
            }
            else if (url == "https://www.pro-football-reference.com/teams/jax/2024.htm")
            {
                Console.WriteLine("Jacksonville Jaguars:");
            }
            else if (url == "https://www.pro-football-reference.com/teams/oti/2024.htm")
            {
                Console.WriteLine("Tennessee Titans:");
            }

            display(PF, yards, passingTD);
        }

        public void controllerAFCNorth(string url)
        {
            myUtilities myUtil = new myUtilities();
            HtmlDocument html = myUtil.fetchHTML(url);
            string PF = fetchPointsFor(html);
            string yards = fetchYards(html);
            string passingTD = fetchPassingTD(html);

            if (url == "https://www.pro-football-reference.com/teams/rav/2024.htm")
            {
                Console.WriteLine("Baltimore Ravens:");
            }
            else if (url == "https://www.pro-football-reference.com/teams/pit/2024.htm")
            {
                Console.WriteLine("Pittsburgh Steelers:");
            }
            else if (url == "https://www.pro-football-reference.com/teams/cin/2024.htm")
            {
                Console.WriteLine("Cincinnati Bengals:");
            }
            else if (url == "https://www.pro-football-reference.com/teams/cle/2024.htm")
            {
                Console.WriteLine("Cleaveland Browns:");
            }

            display(PF, yards, passingTD);
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