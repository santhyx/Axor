using Domain.Models;
using Domain.Types;

namespace Domain.Repositories
{
    public interface IUserRepository : IRepository
    {
        public Task<User?> GetAsync(Guid id);
        public Task AddAsync(User user);
        public Task UpdateAsync(User user);
    }
}
