using API.Data;
using API.Entities;
using API.Interfaces;

namespace API.Repositories;

public class UserRepository : GenaricRepository<User>, IUserRepository
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDbContext _dbContext;

    public UserRepository(IUnitOfWork unitOfWork, IDbContext dbContext)
    {
        _unitOfWork = unitOfWork;
        _dbContext = dbContext;
    }

 
}
