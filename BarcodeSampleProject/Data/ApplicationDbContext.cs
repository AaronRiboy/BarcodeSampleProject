using BarcodeSampleProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarcodeSampleProject.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base (options)
        {
        }

        public DbSet<ProductViewModel> Product { get; set; }
    }
}
