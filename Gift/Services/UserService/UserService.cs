using Gift.Models;
using Gift.Models.Requests;
using Gift.Models.Responses;
using Gift.Repository;
using Gift.Utils;

namespace Gift.Services.UserService;

public class UserService : IUserService
{

    private DataContext _context { get; set; }
	private readonly IJwtUtils _jwt;

	public UserService(DataContext context, IJwtUtils jwt)
    {
        _context = context;
		_jwt=jwt;
	}

    public async Task<Guid?> AddUser(UserSignupRequest request)
    {
        if (!IsValidUsername(request.Username) || !IsValidEmail(request.Email))
            return null;

		User user = new() { UserName = request.Username, Password = EncryptPassword(request.Password), CreatedAt = DateTime.Now };
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        return user.Id;
    }
	public async Task<AuthenticateResponse?> AuthenticateUser(AuthenticateRequest request)
    {
        try
        {
			var user = _context.Users.SingleOrDefault(x => x.UserName == request.Username && x.Password == Decrypti(request.Password));

			// return null if user not found
			if (user == null) return null;

			// authentication successful so generate jwt token
			var token = _jwt.GenerateJwtToken(user);

			return new AuthenticateResponse(user, token);
		}
        catch (Exception e) { throw e; }
        
	}

    public async Task<List<Era>> GetErasForUser(int? userId)
    {
        return await _context.Eras.Where(o=>o.User == userId).ToListAsync();
    }

	private bool IsValidUsername(string username) =>  username.Length > 0;
	private bool IsValidEmail(string email) =>  email.Length > 0;

    private string EncryptPassword(string password) => $"Encrypted{password}";
    private bool VerifyPassword(Guid id, string requestPassword) => true;
    private string Decrypti(string requestPassword) => $"Encrypted{requestPassword}";
	/**
        public Task<User?> GetCurrentUser(int? id)
    {
        return _context.Users.FirstOrDefaultAsync(o => o.UserName == UserName;
    }*/
}