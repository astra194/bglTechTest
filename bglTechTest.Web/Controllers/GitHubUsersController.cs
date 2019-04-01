using bglTechTest.Web.Application.GitHubUserSearch;
using bglTechTest.Web.Application.GitHubUserSearch.CreateModel;
using bglTechTest.Web.Application.GitHubUserSearch.Search;
using bglTechTest.Web.Infrastructure.RequestResponse;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace bglTechTest.Web.Controllers
{
    public partial class GitHubUsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GitHubUsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: GitHubUsers
        [HttpGet]
        public virtual async Task<ActionResult> Search(CancellationToken cancellationToken)
        {
            IRequestResponse<CreateGitHubUserSearchModelResponse> response = await _mediator.Send(new CreateGitHubUserSearchModelRequest(), cancellationToken);
            return View(ToViewModel(response, r => r.Model, () => null));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> Search(GitHubUserSearchModel model, CancellationToken cancellationToken)
        {
            IRequestResponse<GitHubUserSearchResponse> response = await _mediator.Send(new GitHubUserSearchRequest(model), cancellationToken);
            return View(ToViewModel(response, r => r.Model, () => model));
        }
    }
}