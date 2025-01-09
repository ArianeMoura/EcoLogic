using app.Models.Entities;

namespace app.Models
{
    public class UsinaViewModel
    {
        public IEnumerable<Cidade> Cidades { get; set; }
        public IEnumerable<Cliente> Clientes { get; set; }
        public IEnumerable<FonteDeEnergia> FontesEnergia { get; set; }
    }
}