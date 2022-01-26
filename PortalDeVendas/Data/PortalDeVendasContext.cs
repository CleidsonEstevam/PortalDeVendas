using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortalDeVendas.Models;

namespace PortalDeVendas.Data
{
    public class PortalDeVendasContext : DbContext
    {
        public PortalDeVendasContext (DbContextOptions<PortalDeVendasContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RelatorioDeVendas> RelatorioDeVendas { get; set; }


    }
}
