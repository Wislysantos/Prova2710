using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prova2710.Pages.Modus;

namespace Prova2710.Data
{
    public class Prova2710Context : DbContext
    {
        public Prova2710Context (DbContextOptions<Prova2710Context> options)
            : base(options)
        {
        }

        public DbSet<Prova2710.Pages.Modus.Funcionario> Funcionario { get; set; }
    }
}
