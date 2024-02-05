using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class Register : AccountBase
    {
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string? FullName { get; set; }

        [DataType(DataType.EmailAddress)]
        [MinLength(5)]
        [MaxLength(100)]
        [Compare(nameof(Password))]
        [Required]
        public string? ConfirmPassword { get; set; }
    }
}
