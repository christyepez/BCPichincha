using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiRestBP.Models
{
    public partial class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }

    
    }
}
