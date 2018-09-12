using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using Newtonsoft.Json;

namespace UnitTest_CoreAPI
{
    [TestClass]
    public class UnitTest1
    {
        private static string _webAPIURL = "http://localhost:52269/api/HelloWorld/Name";


        [TestMethod]
        public void TestGetNameMethod()
        {
            var deserializedOutput = "";

            string strExpectedOutput = "WEB API - Hello world";


            using (var client = new HttpClient())
            {
               var result = client.GetAsync(_webAPIURL).Result;

                if (result.IsSuccessStatusCode)
                {
                    deserializedOutput = result.Content.ReadAsStringAsync().Result;
                    //deserializedOutput = JsonConvert.DeserializeObject(output);
                }
            }


            Assert.AreEqual(deserializedOutput, strExpectedOutput);
        }
    }
}
