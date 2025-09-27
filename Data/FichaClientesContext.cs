using FichaClientes.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FichaClientes.Data
{
    public class FichaClientesContext : DbContext
    {
        public FichaClientesContext(DbContextOptions<FichaClientesContext> options)
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}