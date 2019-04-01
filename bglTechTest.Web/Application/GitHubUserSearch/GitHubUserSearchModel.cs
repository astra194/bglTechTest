using bglTechTest.Domain;
using System.Collections.Generic;

namespace bglTechTest.Web.Application.GitHubUserSearch
{
    public class GitHubUserSearchModel
    {
        public string UserName { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string AvatarUrl { get; set; }

        public string ReposUrl { get; set; }

        public List<Repository> Repositories { get; set; }
    }
}