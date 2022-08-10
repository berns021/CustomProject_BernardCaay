using CustomProject_BernsCaay.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CustomProject_BernsCaay
{
    internal class APICall
    {
  

        public static string[] topArticles(int limit)
        {

            var url = "https://jsonmock.hackerrank.com/api/articles?page=" + limit.ToString();

            var request = WebRequest.Create(url);
            request.Method = "GET";

            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            Articles myDeserializedClass = JsonConvert.DeserializeObject<Articles>(data);

            List<string> retval = new List<string>();
     


            foreach (var deserializedClass in myDeserializedClass.data)
            {
                if (deserializedClass.title != null)
                {
                    retval.Add(deserializedClass.title);
                }
                else if (deserializedClass.story_title != null)
                {
                    retval.Add(deserializedClass.story_title);
                }

            }
            retval.Sort((a, b) => b.CompareTo(a));


            var final = retval.Take(limit);

            return final.ToArray();


        }

    }
}
