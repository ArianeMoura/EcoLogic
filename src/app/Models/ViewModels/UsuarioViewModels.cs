using System.ComponentModel.DataAnnotations;
using app.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace app.Models.ViewModels
{
    public class UsuarioCreateViewModel
    {
        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

       
        

        [Required]
        public Guid ClienteId { get; set; }
        public IEnumerable<SelectListItem>? Clientes { get; set; }
 


        [Required]
        public List<Guid> GrupoPermissaoIds { get; set; } = new List<Guid>();
        public IEnumerable<SelectListItem>? GruposPermissoes { get; set; }

    }

    public class UsuarioUpdateViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public Guid ClienteId { get; set; }
        public IEnumerable<SelectListItem>? Clientes { get; set; }

        [Required]
        public List<Guid> GrupoPermissaoIds { get; set; } = new List<Guid>();
        public IEnumerable<SelectListItem>? GruposPermissoes { get; set; }


    }

    public class UsuarioListViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string ClienteNome { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
