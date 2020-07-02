using AutoMapper;
using IEIMobile.Models.Dtos;

namespace IEIMobile.Models.Profiles
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            // source => destination
            CreateMap<UserDto, User>();
        }
    }
}