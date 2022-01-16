using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiRestBP.Models
{
    public partial class ReporteEstado
    {
        //public int ReporteId { get; set; }
        //public int? MovimientoId { get; set; }
        //public DateTime? FechaReporte { get; set; }
        [Key]
        public int ReporteId { get; set; }
        public string Numero { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public decimal SaldoContable { get; set; }
        public decimal SaldoInicial { get; set; }

    }
}
