using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Password { get; set; }

    }
}
