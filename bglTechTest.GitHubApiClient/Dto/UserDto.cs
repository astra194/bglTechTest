using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace bglTechTest.GitHubApiClient.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UserDto
    {
        public string Login { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string AvatarUrl { get; set; }

        public string ReposUrl { get; set; }
    }
}
