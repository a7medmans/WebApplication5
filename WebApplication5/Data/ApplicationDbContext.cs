using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder); 

        //    var configuration = new ConfigurationBuilder()  
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    var ConnectionStrings = configuration.GetSection("ConnectionStrings").Value;

        //    optionsBuilder.UseSqlServer(ConnectionStrings);
        //}

    }
}