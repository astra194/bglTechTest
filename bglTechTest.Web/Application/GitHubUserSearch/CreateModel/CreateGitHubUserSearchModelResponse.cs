namespace bglTechTest.Web.Application.GitHubUserSearch.CreateModel
{
    public class CreateGitHubUserSearchModelResponse
    {
        public CreateGitHubUserSearchModelResponse()
        {
        }

        public CreateGitHubUserSearchModelResponse(GitHubUserSearchModel model)
        {
            Model = model;
        }

        public GitHubUserSearchModel Model { get; set; }
    }
}