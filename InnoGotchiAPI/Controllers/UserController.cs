using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.BLL.Interfaces;
using InnoGotchi.DAL.Entities;
using InnoGotchiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InnoGotchiAPI.Controllers
{
    public sealed class UserController : Controller
    {
        private readonly IService<User, UserDTO> _userService;
        private readonly IMapper _mapper;
        public UserController(
            IMapper mapper,
            IService<User, UserDTO> userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(RegistrationViewModel registrationViewModel)
        {
            if (!ModelState.IsValid) return View("Register", registrationViewModel);
            var userDTO = _mapper.Map<UserDTO>(registrationViewModel);

            _userService.Create(userDTO);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult AllNicknames()
        {
            List<UserDTO> allUsersDTO = _userService.GetAll().ToList();

            List<UserViewModel> allUserViewModel = new List<UserViewModel>();

            foreach (var userDTO in allUsersDTO)
            {
                UserViewModel userViewModel = _mapper.Map<UserViewModel>(userDTO);
                allUserViewModel.Add(userViewModel);
            }

            return View(allUserViewModel);
        }

        [HttpGet]
        public IActionResult NicknameById() => View();

        [HttpPost]
        public IActionResult NicknameById(IdViewModel idViewModel)
        {
            if (!ModelState.IsValid) return View("NicknameById", idViewModel);

            UserDTO userDTO = _userService.Get(idViewModel.Id);
            UserViewModel userViewModel = _mapper.Map<UserViewModel>(userDTO);

            return View("UserNickname", userViewModel);
        }

        [HttpPost]
        public IActionResult DelitNicknameById(int id)
        {
            _userService.Delete(id);

            return RedirectToAction("AllNicknames", "User");
        }

        [HttpGet]
        public IActionResult UpdateNickname() => View();

        [HttpPost]
        public IActionResult UpdateNickname(UpdateNicknameModel updateNicknameModel)
        {
            if (!ModelState.IsValid) return View("UpdateNickname", updateNicknameModel);

            UserDTO userDTO = _mapper.Map<UserDTO>(updateNicknameModel);
            _userService.Update(userDTO);

            return RedirectToAction("AllNicknames", "User");
        }
    }
}
