using Gift.Models.Requests;
using Gift.Models.Responses;

namespace Gift.Services.UserService;

public interface IUserService
{
	Task<Guid?> AddUser(UserSignupRequest request);
	Task<AuthenticateResponse> AuthenticateUser(AuthenticateRequest request);

	Task<List<Era>> GetErasForUser(int? userId);
	/**Task<User?> GetCurrentUser(int? id);*/
}