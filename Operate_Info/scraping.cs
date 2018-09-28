using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace getTrainRoute
{
    class scraping
    {

        //URLからHTML取得(Unity移行の際にHttpWebRequestからWWWへ変更)
        public string GetHtml(string url)
        {
            var req = (HttpWebRequest)WebRequest.Create(url);

            string html = "";

            using (var res = (HttpWebResponse)req.GetResponse())
            using (var resSt = res.GetResponseStream())

            using(var sr = new StreamReader(resSt,Encoding.UTF8))
            {
                html = sr.ReadToEnd();
            }
            return html;
        }
    }
}
