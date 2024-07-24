using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;


namespace SuperTextToolBox.WordAddIn
{
    public static  class chuansong
    {
        public static string text;
    }
    public class Result
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 回答成功
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string model { get; set; }

        /// <summary>
        /// 你好
        /// </summary>
        public string question { get; set; }

        /// <summary>
        /// 你好！很高兴能为你提供帮助。如果有任何问题或需要任何信息，请随时告诉我。我会尽力为你解答。
        /// </summary>
        public string answer { get; set; }

        /// <summary>
        /// 官方API网:https://api.pearkture.cn/
        /// </summary>
        public string api_source { get; set; }

    }
    public static class AITool
    {
        public static string type;
        public static void MakeText()
        {
           
        }
        public static Result GetAnswer(string ask)
        {

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.pearktrue.cn/api/qwen/?question=" + ask);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string unprocessresult = reader.ReadToEnd();
            Result result = JsonConvert.DeserializeObject<Result>(unprocessresult);
            return result;
        }
    }
}
