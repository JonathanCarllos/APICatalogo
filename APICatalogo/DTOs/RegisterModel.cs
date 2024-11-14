using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? UserName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Password { get; set; }
    }

}
