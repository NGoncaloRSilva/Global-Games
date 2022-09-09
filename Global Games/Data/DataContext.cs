using Global_Games.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Global_Games.Data
{
    
        public class DataContext : DbContext
        {

            public DbSet<Newsletter> Newsletters { get; set; }
            public DbSet<Budget> Budgets { get; set; }

            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {
            }
        }
    
}
