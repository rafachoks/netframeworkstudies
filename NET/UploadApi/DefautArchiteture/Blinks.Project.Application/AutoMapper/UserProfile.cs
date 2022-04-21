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
                dest => dest.Age,
                opt => opt.MapFrom(src => $"{Convert.ToInt32(src.Age)}")
                )
                .ForMember(
                dest => dest.IsActive,
                opt => opt.MapFrom(src => $"{Convert.ToBoolean(src.IsActive)}")
                )
                .ForMember(
                dest => dest.CreateDate,
                opt => opt.MapFrom(src => $"{Convert.ToDateTime(src.CreateDate)}")
                )
                .ForMember(
                dest => dest.UpdateDate,
                opt => opt.MapFrom(src => $"{Convert.ToDateTime(src.UpdateDate)}")
                ).ReverseMap()
                ;
        }
    }
}
