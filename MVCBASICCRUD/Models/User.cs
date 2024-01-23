using System;
using System.Collections.Generic;

namespace MVCBASICCRUD.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Clave { get; set; }
    }
}
