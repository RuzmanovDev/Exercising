using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebCrawler
{
    class HTMLParser
    {
        public List<string> GetImgSrcs(string html)
        {
            string pattern = "<img.+?src=\"(.+?)\".*?";
            Regex rgx = new Regex(pattern);
            List<string> imgUrls = new List<string>();
            foreach (Match match in rgx.Matches(html))
            {
                imgUrls.Add(match.Groups[1].Value);
            }
            return imgUrls;
        }
    }
}
