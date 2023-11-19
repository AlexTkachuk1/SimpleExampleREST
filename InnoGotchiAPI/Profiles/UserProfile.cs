using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchiAPI.Models;

namespace InnoGotchiAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDTO, UserViewModel>().ReverseMap();
            CreateMap<UserDTO, RegistrationViewModel>().ReverseMap();
            CreateMap<UserDTO, UpdateNicknameModel>().ReverseMap();
        }
    }
}
