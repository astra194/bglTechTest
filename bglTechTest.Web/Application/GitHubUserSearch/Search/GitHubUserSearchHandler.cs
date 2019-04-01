using AutoMapper;
using bglTechTest.Domain;
using bglTechTest.GitHubApiClient;
using bglTechTest.Web.Infrastructure.RequestResponse;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace bglTechTest.Web.Application.GitHubUserSearch.Search
{
    public class GitHubUserSearchHandler : RequestResponseHandler<GitHubUserSearchRequest, GitHubUserSearchResponse>
    {
        private readonly IGitHubApiClient _apiClient;
        private readonly IMapper _mapper;

        public GitHubUserSearchHandler(IGitHubApiClient apiClient, IMapper mapper)
        {
            _apiClient = apiClient;
            _mapper = mapper;
        }

        protected override async Task<IRequestResponse<GitHubUserSearchResponse>> HandleRequest(GitHubUserSearchRequest request, CancellationToken cancellationToken)
        {
            User user = await _apiClient.GetGitHubUser(request.Model.UserName);
            if (!string.IsNullOrEmpty(user.ReposUrl))
            {
                var repos = await _apiClient.GetGitHubRepositories(user.ReposUrl);
                user.Repositories = repos.OrderByDescending(r => r.StargazersCount).Take(5).ToList();
            }

            var model = _mapper.Map<User, GitHubUserSearchModel>(user);
            var response = new GitHubUserSearchResponse(model);
            return Success(response);
        }
    }
}