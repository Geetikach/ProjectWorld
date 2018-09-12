using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Test_Console
{
    class Program
    {

        private static string _webAPIURL = ConfigurationManager.AppSettings["WebAPIServiceURL"];

        static void Main(string[] args)
        {

            using (var client = new HttpClient())
            {
                string strInput = "MyName";

                var result = client.GetAsync(_webAPIURL).Result;
               
                if(result.IsSuccessStatusCode)
                {
                    var output = result.Content.ReadAsStringAsync().Result;
                    var deserializedOutput = JsonConvert.DeserializeObject(output);
                }
            }
        }
    }
}
