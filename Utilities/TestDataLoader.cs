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
            var baseUrlToken = jObject["BaseUrl"];
            if (baseUrlToken == null)
            {
                throw new InvalidOperationException("BaseUrl is missing in the configuration file.");
            }
            return baseUrlToken.ToString();
        }

        public static UserData LoadUserData()
        {
            var json = File.ReadAllText("TestData/UserData.json");
            var userData = JsonConvert.DeserializeObject<UserData>(json);
            if (userData == null)
            {
                throw new InvalidOperationException("Failed to deserialize UserData from the JSON file.");
            }
            return userData;
        }
    }

    public class UserData
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
