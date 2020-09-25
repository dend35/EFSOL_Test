using Microsoft.EntityFrameworkCore;
using Test.Model;

namespace Test.Context
{
    public sealed class AppContext : DbContext
    {
        public DbSet<UserData> UserData { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;UserId=root;Password=root;database=efsol_test_db;");
        }
    }
}