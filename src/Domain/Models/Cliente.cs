using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Cliente
    {
        public string Id { get; set; }

        public string Ciudad { get; set; }

        public int NIT { get; set; }

        public IEnumerable<Factura> Facturas { get; set; }

        public IEnumerable<Mensaje> Mensajes { get; set; }
    }
}
