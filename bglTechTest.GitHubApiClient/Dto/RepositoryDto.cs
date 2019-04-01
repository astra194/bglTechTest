using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace bglTechTest.GitHubApiClient.Dto
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RepositoryDto
    {
        public string Name { get; set; }

        public int StargazersCount { get; set; }
    }
}
