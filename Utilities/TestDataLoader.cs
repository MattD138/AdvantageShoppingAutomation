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
        public static dynamic LoadUserData()
        {
            var json = File.ReadAllText("TestData/UserData.json");
            return JsonConvert.DeserializeObject<dynamic>(json);
        }
    }
}
