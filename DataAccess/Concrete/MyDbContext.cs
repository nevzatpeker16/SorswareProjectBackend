using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class MyDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Park> Parks { get; set; }
        
        public DbSet<ParkLog> ParkLogs { get; set; }

    }
}
