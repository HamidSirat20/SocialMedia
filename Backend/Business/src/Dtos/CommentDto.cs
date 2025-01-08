namespace Business.src.Dtos;

public record CommentReadDto(
    Guid Id,
    Guid PostId,
    Guid UserId,
    string Content,
    DateTime CreatedAt
);

public record CommentCreateDto(
    Guid PostId,
    Guid UserId,
    string Content
);

public record CommentUpdateDto(
    string Content
);
