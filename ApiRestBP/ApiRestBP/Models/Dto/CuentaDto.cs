namespace ApiRestBP.Models.Dto
{
    public class CuentaDto
    {
        public int CuentaId { get; set; }

        public int ClienteId { get; set; }
        public string Numero { get; set; }
        public decimal Saldo { get; set; }

    }
}
