namespace Domain.src.Entities;

public class Comment
{
    public Guid Id { get; set; }
    public Guid PostId { get; set; } // Foreign key to Post
    public Guid UserId { get; set; } // Foreign key to User
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relationships
    public Post Post { get; set; } = null!;
    public User User { get; set; } = null!;
}