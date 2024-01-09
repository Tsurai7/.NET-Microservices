using PlatformService.Models;

namespace PlatformService.Data;

public static class PrepDb
{
    public static void PrepPopulation(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        
        SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
    }

    private static void SeedData(AppDbContext context)
    {
        if (!context.Platforms.Any())
        {
            Console.WriteLine("--> Seeding data");
            
            context.Platforms.AddRange(
                new Platform() {Name = "DotNet", Publisher = "Microsoft", Cost = "Free"},
                new Platform() {Name = "Minecraft", Publisher = "Microsoft", Cost = "Free"},
            new Platform() {Name = "Kebernetes", Publisher = "Microsoft", Cost = "Free"});

            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("--> We already have data");
        }
    }
}