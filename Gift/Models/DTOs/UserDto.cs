namespace Gift.Models.DTOs;
/**
 * To avoid exposing db entities to client and to shape the data
 * we want them to receive, use Dtos 
 */
public class UserDto
{
    public string Name { get; set; } = string.Empty;
}