using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Factura
    {
        public string Id { get; set; }

        public double TotalFactura { get; set; }

        public double SubTotal { get; set; }

        public double Iva { get; set; }

        public double Retencion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string Estado { get; set; }

        public bool Pagada { get; set; }

        public DateTime FechaDePago {get; set;}

        public Cliente Cliente { get; set; }
    }
}
