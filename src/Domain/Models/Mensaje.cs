using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Mensaje
    {
        public string Id { get; set; }

        public string Notificacion { get; set; }

        public Cliente Cliente { get; set; }
    }
}
