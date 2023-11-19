using InnoGotchi.BLL.DTO;
using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.Interfaces
{
    public interface IUserService
    {
        void Create(UserDTO userDTO);
        void Update(UserDTO userDTO);
        void Delete(int userId);
        User Get(int userId);
        IEnumerable<User> GetAll();
    }
}
