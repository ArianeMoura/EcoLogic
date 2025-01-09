using System.ComponentModel.DataAnnotations;

namespace app.Models.ViewModels
{
    public class RedefinirSenhaViewModel
    {

        public string Email { get; set; }
        public string Token { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string NovaSenha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("NovaSenha", ErrorMessage = "As senhas não coincidem. Digite novamente, de forma que sejam iguais.")]
        public string ConfirmarSenha { get; set; }
    }

}

