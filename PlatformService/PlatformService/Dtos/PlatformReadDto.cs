namespace PlatformService.Dtos;

public record PlatformReadDto
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public string Publisher { get; set; }
    
    public string Cost { get; set;  }
}