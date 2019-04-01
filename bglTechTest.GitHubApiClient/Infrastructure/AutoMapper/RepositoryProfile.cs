using AutoMapper;
using bglTechTest.Domain;
using bglTechTest.GitHubApiClient.Dto;

namespace bglTechTest.GitHubApiClient.Infrastructure.AutoMapper
{
    internal class RepositoryProfile : Profile
    {
        public RepositoryProfile()
        {
            CreateMap<RepositoryDto, Repository>();
        }
    }
}
