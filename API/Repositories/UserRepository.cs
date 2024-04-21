using API.Data;
using API.Entities;
using API.Interfaces;

namespace API.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDbContext _dbContext;

    public UserRepository(IUnitOfWork unitOfWork, IDbContext dbContext)
    {
        _unitOfWork = unitOfWork;
        _dbContext = dbContext;
    }

    public void Create(User user)
    {
        _dbContext.Inster(user);
    }

    public void Delete(Guid userId)
    {
        _dbContext.Set<>().Remove(userId);
    }

    public Task<List<User>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByEmailAsync(string userEmail)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByUserNameAsync(string userName)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(User user)
    {
        throw new NotImplementedException();
    }
}
