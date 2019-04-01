using AutoMapper;
using bglTechTest.Domain;
using bglTechTest.GitHubApiClient.Dto;

namespace bglTechTest.GitHubApiClient.Infrastructure.AutoMapper
{
    internal class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>();
        }
    }
}
