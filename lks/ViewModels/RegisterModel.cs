using System.ComponentModel.DataAnnotations;

namespace lks.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Не указан Email")]
        public string Email { get; set; }
         
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Не указано имя")]
        [DataType(DataType.Password)]
        public string Name { get; set; }
    }
}