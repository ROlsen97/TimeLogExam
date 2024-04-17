using Application.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TimeLogDbContext _dbContext;

        public UserRepository(TimeLogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ICollection<User>> GetAll()
        {
            return await _dbContext.User.ToListAsync();
        }
    }
}
