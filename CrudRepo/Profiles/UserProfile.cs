using AutoMapper;
using CrudRepo.Dtos.User;
using CrudRepo.Enities;

namespace CrudRepo.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {

            CreateMap<User, UserforListing>();
            CreateMap<User, UserDto>();
            CreateMap<UserForCreation,User>();
            CreateMap<UserForUpdation,User>();
        
        }
    }
}
