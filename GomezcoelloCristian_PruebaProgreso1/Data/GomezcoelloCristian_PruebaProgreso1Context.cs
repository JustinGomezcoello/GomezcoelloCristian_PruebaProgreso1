using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GomezcoelloCristian_PruebaProgreso1.Models;

namespace GomezcoelloCristian_PruebaProgreso1.Data
{
    public class GomezcoelloCristian_PruebaProgreso1Context : DbContext
    {
        public GomezcoelloCristian_PruebaProgreso1Context (DbContextOptions<GomezcoelloCristian_PruebaProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<GomezcoelloCristian_PruebaProgreso1.Models.Celular> Celular { get; set; } = default!;
        public DbSet<GomezcoelloCristian_PruebaProgreso1.Models.Gomezcoello> Gomezcoello { get; set; } = default!;
    }
}
