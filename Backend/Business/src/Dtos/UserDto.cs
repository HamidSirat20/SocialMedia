namespace Business.src.Dtos;

public record UserReadDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Username,
    string Email,
    DateTime DateOfBirth,
    string ProfilePicture,
    string CoverPhoto,
    string Bio,
    DateTime CreatedAt
);

public record UserCreateDto(
    string FirstName,
    string LastName,
    string Username,
    string Email,
    DateTime DateOfBirth,
    string Password,
    string ProfilePicture,
    string CoverPhoto,
    string Bio
);

public record UserUpdateDto(
    string FirstName,
    string LastName,
    string Email,
    string ProfilePicture,
    string CoverPhoto,
    string Bio
);
