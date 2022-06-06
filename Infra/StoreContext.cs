using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<ContaBancaria> Cc { get; set; }
        public DbSet<DetalhesConta> Detalhes { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }

    }
}
