namespace Gift.Models.DTOs;

public record UserDto(Guid Id, string Username, string Password, string Email, IEnumerable<Era> Eras);