using System;

namespace app.Models
{
    public class DeleteUsinaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal CapacidadeKW { get; set; }
        public DateTime DataInicio { get; set; }
        public bool StatusOperacional { get; set; }
        public string Endereco { get; set; }
        public string CidadeNome { get; set; }
        public string ClienteNome { get; set; }
        public string FonteDeEnergiaNome { get; set; }
    }
}
