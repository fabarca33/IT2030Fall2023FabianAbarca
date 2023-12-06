using Microsoft.EntityFrameworkCore;
using FabianMusic.Models;

namespace FabianMusic.Data
{
    public class FabianMusicContext : DbContext
    {
        public FabianMusicContext(DbContextOptions<FabianMusicContext> options) 
            : base(options) { }
        public DbSet<ProductModel> ProductDb { get; set; } = null!;
   
        public DbSet<ContactModel> ContactDb { get; set; } = null!;
    }
}
