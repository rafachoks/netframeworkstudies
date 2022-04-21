using AutoMapper;
using Blinks.Project.Application.Model;
using Blinks.Project.Domain;

namespace Blinks.Project.Application.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, User>();
        }
    }
}
