using PlatformService.Models;

namespace PlatformService.Data;

public interface IPlatformRepository
{
    bool SaveChanges();

    IEnumerable<Platform> GetAllPlatforms();

    Platform GetPlatformById(long id);

    void CreatePlatform(Platform platform); 

}