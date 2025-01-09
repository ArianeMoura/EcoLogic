using app.Models.Entities;

namespace app.Models
{
    public class EditCidadeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Estado Estado { get; set; }
    }
}