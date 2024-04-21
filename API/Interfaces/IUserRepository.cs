using API.Entities;

namespace API.Interfaces;

public interface IUserRepository
{
    // Command
    void Create(User user);
    Task<bool> Update(User user);
    void Delete(Guid userId);

    // Query
    Task<List<User>> GetAllAsync();
    Task<User> GetByIdAsync(Guid userId);
    Task<User> GetByEmailAsync(string userEmail);
    Task<User> GetByUserNameAsync(string userName);
}
