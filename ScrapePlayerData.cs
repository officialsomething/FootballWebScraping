using HtmlAgilityPack;
using System;
using System.Net.Http;
using utilities;

namespace OtherWebScraper
{
    public class PlayerProgram
    {
        List<string> WR_List = new List<string>();
        List<string> RB_List = new List<string>();
        List<string> QB_List = new List<string>();
        List<string> TE_List = new List<string>();
        List<string> FB_List = new List<string>();
        
        
        public void fetchOffensivePlayers(string url)
        {
            myUtilities myUtil = new myUtilities();
            HtmlDocument html = myUtil.fetchHTML(url);

            for (int i = 1; i < 50; i++)
            {
                var playerName_Element = html.DocumentNode.SelectSingleNode($"//*[@id=\"rushing_and_receiving\"]/tbody/tr[{i}]/td[1]");
                string playerName = playerName_Element.InnerText;
                var position_Element = html.DocumentNode.SelectSingleNode($"//*[@id=\"rushing_and_receiving\"]/tbody/tr[{i}]/td[3]");
                string position = position_Element.InnerText;

                if (position == "RB")
                {
                    RB_List.Add(playerName);
                }
                else if (position == "WR")
                {
                    WR_List.Add(playerName);
                }
                else if (position == "QB")
                {
                    QB_List.Add(playerName);
                }
                else if (position == "TE")
                {
                    TE_List.Add(playerName);
                }
                else
                {
                    FB_List.Add(playerName);
                }
            }

            Console.WriteLine("The running backs are: ");
            foreach (string player in RB_List)
            {
                Console.WriteLine(player);
            }
        }
    }
}