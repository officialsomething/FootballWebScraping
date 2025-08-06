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
            program.controllerAFCEast(url);
            url = "https://www.pro-football-reference.com/teams/mia/2024.htm";
            program.controllerAFCEast(url);
            url = "https://www.pro-football-reference.com/teams/nwe/2024.htm";
            program.controllerAFCEast(url);
            url = "https://www.pro-football-reference.com/teams/nyj/2024.htm";
            program.controllerAFCEast(url);

            Console.WriteLine("Here are the stats for the AFC South.");
            url = "https://www.pro-football-reference.com/teams/htx/2024.htm";
            program.controllerAFCSouth(url);
            url = "https://www.pro-football-reference.com/teams/clt/2024.htm";
            program.controllerAFCSouth(url);
            url = "https://www.pro-football-reference.com/teams/jax/2024.htm";
            program.controllerAFCSouth(url);
            url = "https://www.pro-football-reference.com/teams/oti/2024.htm";
            program.controllerAFCSouth(url);

            Console.WriteLine("Here are the stats for the AFC North.");
            url = "https://www.pro-football-reference.com/teams/rav/2024.htm";
            program.controllerAFCNorth(url);
            url = "https://www.pro-football-reference.com/teams/pit/2024.htm";
            program.controllerAFCNorth(url);
            url = "https://www.pro-football-reference.com/teams/cin/2024.htm";
            program.controllerAFCNorth(url);
            url = "https://www.pro-football-reference.com/teams/cle/2024.htm";
            program.controllerAFCNorth(url);

        }
    }
}