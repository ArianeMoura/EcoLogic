using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models.Entities;

namespace app.Models
{
    public class AddCidadeViewModel
    {
        public string Name { get; set; }
        public Guid EstadoId { get; set; }
        public List<Estado> Estados { get; set; }
    }
}
