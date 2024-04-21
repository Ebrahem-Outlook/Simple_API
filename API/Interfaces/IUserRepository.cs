using API.Entities;

namespace API.Interfaces;

public interface IUserRepository
{
    Task<User> GetByEmailAsync(string email);
    Task<User> GetByUserNameAsync(string email);
    Task<bool> IsEmailUniqueAsync(string email);
    Task<bool> IsUserNameUniqueAsync(string userName);
}
