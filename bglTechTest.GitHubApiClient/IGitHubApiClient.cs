using bglTechTest.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bglTechTest.GitHubApiClient
{
    public interface IGitHubApiClient
    {
        Task<User> GetGitHubUser(string login);

        Task<IEnumerable<Repository>> GetGitHubRepositories(string reposUrl);
    }
}
