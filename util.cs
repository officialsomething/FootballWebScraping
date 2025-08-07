using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace utilities
{
    public class utility
    {
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
    }
}