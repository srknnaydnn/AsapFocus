using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsapFocus.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SERKAN\\MSSQLSERVER01; database=AsapFocus; integrated security=true");
        }

        public DbSet<Hs_ExpenseType>  Hs_ExpenseTypes { get; set; }
        public DbSet<HS_CostOfFuture>  HS_CostOfFutures { get; set; }

    }
}
