using System.ComponentModel.DataAnnotations;

namespace InnoGotchiAPI.Models
{
    public sealed record RegistrationViewModel
    {
        [Required(ErrorMessage = "Необходимо указать вашу")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Длинна имени должна составлять от 2 до 10 символов")]
        public string Nickname { get; set; }
    }
}
