using HtmlAgilityPack;
using System;
using System.Net.Http;
using utilities;

namespace OtherWebScraper
{
    public class PlayerProgram
    {
        public void fetchPlayers(string url)
        {
            utility myUtil = new utility();
            HtmlDocument html = myUtil.fetchHTML(url);
        }
    }
}