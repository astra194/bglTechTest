using AutoMapper;
using bglTechTest.Domain;
using bglTechTest.GitHubApiClient.Dto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace bglTechTest.GitHubApiClient
{
    public class GitHubApiClient : IGitHubApiClient
    {
        private readonly HttpClient _client;
        private readonly IMapper _mapper;

        public GitHubApiClient(HttpClient client, IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }

        public async Task<User> GetGitHubUser(string login)
        {
            string path = $"users/{Uri.EscapeUriString(login)}";
            var response = await _client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            var userDto = await response.Content.ReadAsAsync<UserDto>();
            var user = _mapper.Map<UserDto, User>(userDto);
            return user;
        }

        public async Task<IEnumerable<Repository>> GetGitHubRepositories(string reposUrl)
        {
            var response = await _client.GetAsync(reposUrl);
            response.EnsureSuccessStatusCode();
            var reposDto = await response.Content.ReadAsAsync<IEnumerable<RepositoryDto>>();
            var repos = _mapper.Map<IEnumerable<RepositoryDto>, IEnumerable<Repository>>(reposDto);
            return repos;
        }
    }
}
