

using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Context
{
    public class PlatformDbContext :DbContext
    {
       public PlatformDbContext(DbContextOptions<PlatformDbContext> options):base(options)
       {
           
       }
       public DbSet<Platform> Platforms { get; set; }
    }
}