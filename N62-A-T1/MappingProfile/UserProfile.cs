using AutoMapper;
using N62_A_T1.DTOs;
using N62_A_T1.Models;

namespace N62_A_T1.MappingProfile;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserForCreation, User>();
        CreateMap<User, UserForCreation>();
        CreateMap<UserViewModel, User>();
        CreateMap<User, UserViewModel>();
    }
}
