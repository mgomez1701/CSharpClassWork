using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day29IdentityFramework.Models
{
    public class IdentityFrameworkTestDbContext: DbContext
    {
        public IdentityFrameworkTestDbContext(DbContextOptions options) : base(options) { }

        DbSet<Presidents> Presidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Presidents>().HasData(
                new Presidents(44, "Barak Obama", 2, DateTime.Parse("01/01/2009")),
                new Presidents(22, "Grover Cleveland", 1, DateTime.Parse("03/04/1885")),
                new Presidents(24, "Grover Cleveland", 1, DateTime.Parse("03/04/1893")),
                new Presidents(38, "Gerald Ford", 1, DateTime.Parse("09/09/1974"))
               );
        }
    }
}
