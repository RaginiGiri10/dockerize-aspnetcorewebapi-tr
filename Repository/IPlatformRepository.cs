using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService.Repository
{
    public interface IPlatformRepository
    {
        IEnumerable<Platform> GetPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }
}