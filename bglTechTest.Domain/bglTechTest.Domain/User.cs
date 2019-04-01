using System.Collections.Generic;

namespace bglTechTest.Domain
{
    public class User
    {
        public string Login { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string AvatarUrl { get; set; }

        public string ReposUrl { get; set; }

        public List<Repository> Repositories { get; set; }
    }
}
