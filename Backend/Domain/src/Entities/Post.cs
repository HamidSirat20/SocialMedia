namespace Domain.src.Entities;

public class Post
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; } // Foreign key to User
    public string Content { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty; // URL
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relationships
    public User User { get; set; } = null!; // Navigation property
    public ICollection<Like> Likes { get; set; } = new List<Like>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
