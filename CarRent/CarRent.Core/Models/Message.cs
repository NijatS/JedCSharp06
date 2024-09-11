using CarRent.Models.BaseEntities;

namespace CarRent.Models;

public class Message : BaseEntity
{
    public string? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public required string Phone { get; set; }
    public required string Subject { get; set; }
    public required string Body { get; set; }
}