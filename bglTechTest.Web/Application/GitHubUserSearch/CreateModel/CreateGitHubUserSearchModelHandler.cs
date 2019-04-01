using System.Threading;
using System.Threading.Tasks;
using bglTechTest.Web.Infrastructure.RequestResponse;

namespace bglTechTest.Web.Application.GitHubUserSearch.CreateModel
{
    public class CreateGitHubUserSearchModelHandler : RequestResponseHandler<CreateGitHubUserSearchModelRequest, CreateGitHubUserSearchModelResponse>
    {
        protected override Task<IRequestResponse<CreateGitHubUserSearchModelResponse>> HandleRequest(CreateGitHubUserSearchModelRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Success(new CreateGitHubUserSearchModelResponse
            {
                Model = new GitHubUserSearchModel(),
            }));
        }
    }
}