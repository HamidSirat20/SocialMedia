namespace Domain.src.Entities;

public class Like
{
    public Guid Id { get; set; }
    public Guid PostId { get; set; } // Foreign key to Post
    public Guid UserId { get; set; } // Foreign key to User

    // Relationships
    public Post Post { get; set; } = null!;
    public User User { get; set; } = null!;
}
