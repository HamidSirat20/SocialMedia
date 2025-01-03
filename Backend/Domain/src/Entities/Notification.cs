namespace Domain.src.Entities;

public class Notification
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; } // Foreign key to User
    public string Message { get; set; } = string.Empty;
    public bool IsRead { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relationships
    public User User { get; set; } = null!;
}