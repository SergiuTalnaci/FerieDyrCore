using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FerieDyrCore.Models
{
    public class FerieDyrCoreContext : DbContext
    {
        public DbSet<HelloCoreModel> HelloCoreModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FerieDyrCore;Trusted_Connection=True;");
        }
    }
}
