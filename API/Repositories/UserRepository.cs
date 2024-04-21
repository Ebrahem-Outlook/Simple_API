using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class UserRepository : GenaricRepository<User>, IUserRepository
{

    public UserRepository(IUnitOfWork unitOfWork, IDbContext dbContext)
    {
        _unitOfWork = unitOfWork;
        _dbContext = dbContext;
    }

 
}
