using AutoMapper;
using Blinks.Project.Application.Model;
using Blinks.Project.Domain;

namespace Blinks.Project.Application.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, User>()
                .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => $"{src.Name}")
                )
                .ForMember(
                dest => dest.Email,
                opt => opt.MapFrom(src => $"{src.Email}")
                )
                .ForMember(
                dest => Convert.ToInt32(dest.Age),
                opt => opt.MapFrom(src => $"{src.Age}")
                )
                .ForMember(
                dest => Convert.ToBoolean(dest.IsActive),
                opt => opt.MapFrom(src => $"{src.IsActive}")
                )
                .ForMember(
                dest => Convert.ToDateTime(dest.CreateTime),
                opt => opt.MapFrom(src => $"{src.CreateDate}")
                )
                .ForMember(
                dest => Convert.ToDateTime(dest.UpdateTime),
                opt => opt.MapFrom(src => $"{src.UpdateDate}")
                );
        }
    }
}
