namespace Business.src.Dtos;

public record PostReadDto(
    Guid Id,
    Guid UserId,
    string Content,
    string Image,
    DateTime CreatedAt,
    ICollection<LikeReadDto> Likes,
    ICollection<CommentReadDto> Comments
);

public record PostCreateDto(
    Guid UserId,
    string Content,
    string Image
);

public record PostUpdateDto(
    string Content,
    string Image
);
