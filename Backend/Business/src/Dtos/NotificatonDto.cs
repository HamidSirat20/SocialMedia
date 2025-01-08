namespace Business.src.Dtos;

public record NotificationReadDto(
    Guid Id,
    Guid UserId,
    string Message,
    bool IsRead,
    DateTime CreatedAt
);

public record NotificationCreateDto(
    Guid UserId,
    string Message
);

public record NotificationUpdateDto(
    bool IsRead
);
