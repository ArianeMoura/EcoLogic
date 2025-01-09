using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class EditEstadoViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Sigla { get; set; }
    }
}