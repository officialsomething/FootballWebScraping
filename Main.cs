using HtmlAgilityPack;
using System;
using System.Net.Http;
using WebScraper;

namespace mainBoi
{
    class doThing
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Here are the stats for the AFC East.");

            TeamProgram program = new TeamProgram();

            string url = "https://www.pro-football-reference.com/teams/buf/2024.htm";
            program.controller(url);
            url = "https://www.pro-football-reference.com/teams/mia/2024.htm";
            program.controller(url);
            url = "https://www.pro-football-reference.com/teams/nwe/2024.htm";
            program.controller(url);
            url = "https://www.pro-football-reference.com/teams/nyj/2024.htm";
            program.controller(url);            
        }
    }
}