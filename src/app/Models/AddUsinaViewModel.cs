using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models.Entities;

namespace app.Models
{
    public class AddUsinaViewModel
    {
        public List<Cidade> Cidades { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<FonteDeEnergia> FontesDeEnergia { get; set; }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string StatusOperacional { get; set; }

        public DateTime DataInicio { get; set; }
        public decimal CapacidadeKW { get; set; }

        public Guid CidadeId { get; set; }
        public Guid ClienteId { get; set; }
        public Guid FonteDeEnergiaId { get; set; }
    }
}