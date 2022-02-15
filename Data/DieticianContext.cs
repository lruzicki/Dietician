#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Dietician;
using Dietician.Models;

namespace Dietician.Data
{
    public class DieticianContext : DbContext
    {
        public DbSet<Dietician.Models.Chef> Chefs { get; set; }
        public DbSet<MvcMovie.Dietician.Recipe> Recipe { get; set; }

        public DieticianContext (DbContextOptions<DieticianContext> options)
            : base(options)
        {
        }

        public DbSet<Dietician.Models.Publication> Publication { get; set; }

        public DbSet<Dietician.Models.ProjectRole> ProjectRole { get; set; }

    }
}
