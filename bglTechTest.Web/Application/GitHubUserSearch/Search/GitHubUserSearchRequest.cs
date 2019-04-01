using bglTechTest.Web.Infrastructure.RequestResponse;
using MediatR;

namespace bglTechTest.Web.Application.GitHubUserSearch.Search
{
    public class GitHubUserSearchRequest : IRequest<IRequestResponse<GitHubUserSearchResponse>>
    {
        public GitHubUserSearchRequest()
        {
        }

        public GitHubUserSearchRequest(GitHubUserSearchModel model)
        {
            Model = model;
        }

        public GitHubUserSearchModel Model { get; set; }
    }
}