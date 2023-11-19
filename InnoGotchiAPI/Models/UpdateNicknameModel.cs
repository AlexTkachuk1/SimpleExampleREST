using System.ComponentModel.DataAnnotations;

namespace InnoGotchiAPI.Models
{
    public sealed record UpdateNicknameModel
    {
        [Required(ErrorMessage = "Укажите ID пользователя")]
        [Range(1, 10000000000, ErrorMessage = "Значение ID должно входить в разумные пределы от 1 до 10000000000")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо указать вашу")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Длинна имени должна составлять от 2 до 10 символов")]
        public string Nickname { get; set; }
    }
}
