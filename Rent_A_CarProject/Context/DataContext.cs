using GaleriApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GaleriApp.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) { }
        
            
      public DbSet<AracTuru> AracTurleri { get; set; }
    }
}
