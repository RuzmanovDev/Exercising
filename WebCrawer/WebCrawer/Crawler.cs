using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler
{
    public class Crawler
    {
        private HTMLParser parser;
        public Crawler()
        {
            this.parser = new HTMLParser();
        }
        public void Crawl(string url)
        {
            string html;
            using (var client = new WebClient())
            {
                html = client.DownloadString(url);
                List<string> imgUrls = parser.GetImgSrcs(html);
                url = url.TrimEnd('/');
                for (int i = 0; i < imgUrls.Count; i++)
                {
                    if (!imgUrls[i].StartsWith("http"))
                    {
                        imgUrls[i] = url + imgUrls[i];
                    }
                }

                foreach (var img in imgUrls)
                {
                    int lastIndexOfForwardSlash = img.LastIndexOf('/');
                    string fileName = img.Substring(lastIndexOfForwardSlash + 1);


                    try
                    {
                        client.DownloadFile(img, fileName);
                    }
                    catch (WebException wex)
                    {
                        Console.WriteLine(wex.Message);
                    }
                   
                }


            }
        }
    }
}
