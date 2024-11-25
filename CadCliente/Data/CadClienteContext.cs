using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadCliente.Models;

namespace CadCliente.Data
{
    public class CadClienteContext : DbContext
    {
        public CadClienteContext (DbContextOptions<CadClienteContext> options)
            : base(options)
        {
        }

        public DbSet<CadCliente.Models.Cliente> Cliente { get; set; } = default!;
    }
}
