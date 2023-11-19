using System.ComponentModel.DataAnnotations;

namespace InnoGotchiAPI.Models
{
    public sealed record IdViewModel
    {
        [Required(ErrorMessage = "Укажите ID пользователя")]
        [Range(1, 10000000000, ErrorMessage = "Значение ID должно входить в разумные пределы от 1 до 10000000000")]
        public int Id { get; set; }
    }
}
