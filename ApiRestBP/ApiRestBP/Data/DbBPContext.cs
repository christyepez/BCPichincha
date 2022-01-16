using ApiRestBP.Models;
using Microsoft.EntityFrameworkCore; 

namespace ApiRestBP.Data
{
    public class DbBPContext : DbContext
    {

        public DbBPContext(DbContextOptions<DbBPContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Cuenta> Cuentas { get; set; }

        public DbSet<Movimiento> Movimientos { get; set; }

        public DbSet<User> Users { get; set; }
        //    public DbSet<User> Users { get; set; }

    }
}
