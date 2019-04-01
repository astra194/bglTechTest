using AutoMapper;
using bglTechTest.Domain;
using bglTechTest.Web.Application.GitHubUserSearch;

namespace bglTechTest.Web.Infrastructure.AutoMapper
{
    internal class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, GitHubUserSearchModel>()
                .ForMember(m => m.UserName, opt => opt.MapFrom(u => u.Login));
        }
    }
}