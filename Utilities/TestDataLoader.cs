using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AdvantageShoppingAutomation.Utilities
{
    public class TestDataLoader
    {
        public static string LoadBaseUrl()
        {
            var json = File.ReadAllText("TestData/TestConfig.json");
            var jObject = JObject.Parse(json);
            return jObject["BaseUrl"].ToString();
        }

    }
}
