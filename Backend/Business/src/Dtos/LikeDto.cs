namespace Business.src.Dtos;

public record LikeReadDto(
    Guid Id,
    Guid PostId,
    Guid UserId
);

public record LikeCreateDto(
    Guid PostId,
    Guid UserId
);
