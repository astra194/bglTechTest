namespace bglTechTest.Web.Application.GitHubUserSearch.Search
{
    public class GitHubUserSearchResponse
    {
        public GitHubUserSearchResponse()
        {
        }

        public GitHubUserSearchResponse(GitHubUserSearchModel model)
        {
            Model = model;
        }

        public GitHubUserSearchModel Model { get; set; }
    }
}