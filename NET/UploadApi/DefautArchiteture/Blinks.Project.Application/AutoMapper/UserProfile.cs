using AutoMapper;
using Blinks.Project.Application.Model;
using Blinks.Project.Domain;

namespace Blinks.Project.Application.AutoMapper
{
    /// <summary>
    /// Create an automapper profile for the user and map the Model and the Domain responsible for the user
    /// Whenever a new attribute is created in the Domain, you must repeat it in the Model as a string and perform the conversion mapping in this class
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class UserProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile"/> class.
        /// </summary>
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
