using Gift.Models;
using Gift.Repository;

namespace Gift.Services.UserService;

public class UserService : IUserService
{

    private DataContext _context { get; set; }

    public UserService(DataContext context)
    {
        _context = context;
    }
    public async Task<List<Era>> GetErasForUser(int userId)
    {
        return await _context.Eras.ToListAsync();
    }

    /**public User GetAHero(int id)
    {
        var hero = heroes.Find(x => x.Id == id);
        if (hero == null)
            return null;
        return hero;
    }

    public List<User> AddHero(User h)
    {
        heroes.Add(h);
        //_context.Add(hero)
        // await _context.SaveChangesAsync()
        return heroes;
    }

    public List<User> RemoveHero(int id)
    {
        heroes.RemoveAt(id);
        //_context.Remove(hero)
        // await _context.SaveChangesAsync()
        return heroes;
    }

    public List<User> UpdateHero(User request)
    {
        var heroToUpdate = heroes.Find(p => p.Id == request.Id);
        if (heroToUpdate is null)
            return null;
        heroToUpdate.Name = request.Name;
        return heroes;
        // await _context.SaveChangesAsync()
    }*/
}