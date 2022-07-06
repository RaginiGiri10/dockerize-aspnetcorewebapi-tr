using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Context;
using PlatformService.Models;

namespace PlatformService.Extensions
{
    public static class PlatformExtensions
    {

       public static void InitializePlatform(this IApplicationBuilder app)
       {
          using(var serviceScope = app.ApplicationServices.CreateScope())
          {
                var platformDbContext = serviceScope.ServiceProvider.GetRequiredService<PlatformDbContext>();

                platformDbContext.Platforms.AddRange
                (
                   new Platform { Id = 1, Name = ".Net Core", Publisher = "Microsoft", Cost = "Free" },
                   new Platform { Id = 2, Name = "Docker", Publisher = "Docker", Cost = "Free" }
                );

                platformDbContext.SaveChanges();
            }
         
       }
      
    }
}