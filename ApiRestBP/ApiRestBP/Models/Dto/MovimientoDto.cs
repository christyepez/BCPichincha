using System;

namespace ApiRestBP.Models.Dto
{
    public class MovimientoDto
    {
        public int MovimientoId { get; set; } 
        public int CuentaId { get; set; }
        public string Tipo { get; set; } 
        public DateTime Fecha { get; set; } 

        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
    }
}
