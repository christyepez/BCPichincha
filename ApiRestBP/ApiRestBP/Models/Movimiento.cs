using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiRestBP.Models
{
    public partial class Movimiento
    {
        [Key] 
        public int MovimientoId { get; set; }
        public int CuentaId { get; set; }
        public string Tipo { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Saldo { get; set; }
    }
}
