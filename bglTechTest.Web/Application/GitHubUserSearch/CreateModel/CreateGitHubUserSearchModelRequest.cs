using bglTechTest.Web.Infrastructure.RequestResponse;
using MediatR;

namespace bglTechTest.Web.Application.GitHubUserSearch.CreateModel
{
    public class CreateGitHubUserSearchModelRequest : IRequest<IRequestResponse<CreateGitHubUserSearchModelResponse>>
    {
    }
}