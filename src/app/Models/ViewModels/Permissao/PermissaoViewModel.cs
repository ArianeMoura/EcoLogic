namespace app.Models.ViewModels
{
    public class PermissaoViewModel
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class PermissaoCreateViewModel
    {
        public required string Nome { get; set; }
    }

    public class PermissaoUpdateViewModel
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }
    }
}
