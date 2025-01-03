namespace Domain.src.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
    public string PasswordHash { get; set; } = string.Empty;
    public string ProfilePicture { get; set; } = string.Empty; // URL
    public string CoverPhoto { get; set; } = string.Empty; // URL
    public string Bio { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


    // Relationships
    public ICollection<User> Followers { get; set; } = new List<User>();
    public ICollection<User> Following { get; set; } = new List<User>();
    public ICollection<Post> Posts { get; set; } = new List<Post>();
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
