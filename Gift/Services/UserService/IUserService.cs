using Gift.Models;

namespace Gift.Services.UserService;

public interface IUserService
{
    Task<List<Era>> GetErasForUser(int userId);
    /**User GetAHero(int id);
    List<User> AddHero(User h);
    List<User> RemoveHero(int id);
    List<User> UpdateHero(User request);*/
}