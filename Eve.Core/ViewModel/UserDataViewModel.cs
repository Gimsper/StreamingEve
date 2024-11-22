using System.ComponentModel.DataAnnotations;

namespace Eve.Core.ViewModel
{
    public class UserDataViewModel
    {
        [Required]
        [MaxLength(100)]
        public string? Username { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Password { get; set; }
    }
}
