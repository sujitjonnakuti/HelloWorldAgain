using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAgain.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient(ConfigurationManager.AppSettings["BusinessAPI"]);
            var request = new RestRequest("api/Messages");

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            System.Console.WriteLine(content);
            System.Console.ReadKey();
        }
    }
}
