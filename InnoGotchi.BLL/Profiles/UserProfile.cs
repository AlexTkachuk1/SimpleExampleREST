using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
