using CustomProject_BernsCaay.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json.Serialization;

namespace CustomProject_BernsCaay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string stringLimit = String.Empty;
                Console.Write("Input Limit: ");
                stringLimit = Console.ReadLine();
                int limit = Convert.ToInt32(stringLimit);
                var topArticles = APICall.topArticles(limit);
                foreach (var topArticle in topArticles)
                {
                    Console.WriteLine(topArticle);
                }
 

          
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }



    }
}
