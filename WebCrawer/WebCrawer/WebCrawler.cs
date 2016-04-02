using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler
{
    public class WebCrawler
    {
        static Crawler crawler = new Crawler();
        static void Main(string[] args)
        {


            //Console.WriteLine((char)('a' + 1));
            string url = Console.ReadLine();
            while (url != string.Empty)
            {
                crawler.Crawl(url);
                url = Console.ReadLine();
            }



        }
    }
}
