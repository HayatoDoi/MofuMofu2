using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.Web.Script.Serialization;
using System.Collections;

namespace MofuMofu
{
    class ScoreHttps
    {
        private string url = "https://www.nononono.net/mofumofuapi/";

        public Hashtable[] GetRanking()
        {
            WebClient wc = new WebClient();
            NameValueCollection ps = new NameValueCollection();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            try
            {

                //データの受信
                byte[] resData = wc.UploadValues(this.url + "ranking.json", ps);
                wc.Dispose();
                string resText = Encoding.UTF8.GetString(resData);

                return serializer.Deserialize<Hashtable[]>(resText);
            }
            catch(WebException ex)
            {
                return new Hashtable[0];

            }
        }
        public bool SendScore(string name, int score)
        {
            WebClient wc = new WebClient();
            NameValueCollection ps = new NameValueCollection();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            try
            {
                //データの送信
                ps.Add("name", name);
                ps.Add("score", score.ToString("d"));
                byte[] resData = wc.UploadValues(this.url + "score", ps);
                wc.Dispose();
                string resText = Encoding.UTF8.GetString(resData);
                return true;
            }
            catch (WebException ex)
            {
                return false;

            }
        }
    }
}
