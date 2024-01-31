using Microsoft.EntityFrameworkCore;
using Mohmed.Models.Entity;

namespace Mohmed.Models.Data
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }


        public DbSet<Cusmors> Cusmors { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        //    var connection = config.GetSection("constr").Value;
        //    optionsBuilder.UseSqlServer(connection);
        //}
    }
}
