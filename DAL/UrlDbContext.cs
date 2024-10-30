using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DAL
{
    public class UrlDbContext :DbContext

    {
        //  public  DbSet<ShortedUrl> shortedUrls ;
        

        public UrlDbContext(DbContextOptions<UrlDbContext> options) :base(options) 
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// not the best to do that here
        //{
        //    optionsBuilder.UseSqlServer("server =ABDLRHMAN14;Database=ShortedUrls;Trusted_Connection=Yes; TrustServerCertificate=True;");
        //}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //work with Reflection
        }
    }
}
