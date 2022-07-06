using System.Collections.Generic;
using System.Linq;
using PlatformService.Context;
using PlatformService.Models;

namespace PlatformService.Repository
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly PlatformDbContext _platformDbContext;

        public PlatformRepository(PlatformDbContext platformDbContext)
        {
            _platformDbContext = platformDbContext;
        }
        public void CreatePlatform(Platform platform)
        {
            _platformDbContext.Platforms.Add(platform);
            _platformDbContext.SaveChanges();
        }

        public Platform GetPlatformById(int id)
        {
            return _platformDbContext.Platforms.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Platform> GetPlatforms()
        {
            return _platformDbContext.Platforms.ToList();
        }
    }
}