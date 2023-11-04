using Photogram.DataAccess;
using Photogram.Interfaces;
using Photogram.Models;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Photogram.Services
{
    public class UserService : IEntityBaseService<User>
    {
        private readonly IDataContext _appDataContext;
        
        public UserService(IDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public async ValueTask<User> CreateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            if (!IsValidEmailAddress(user.Email))
                throw new Exception("Email address invalid!");

            await _appDataContext.Users.AddAsync(user, cancellationToken);

            if (saveChanges)
                await _appDataContext.Users.SaveChangesAsync(cancellationToken);

            return user;
        }

        public async ValueTask<User> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var deletedUser = await GetByIdAsync(id);
            
            deletedUser.IsDeleted = true;

            return deletedUser;
        }

        public async ValueTask<User> DeleteAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var deletedUser = await GetByIdAsync(user.Id);

            deletedUser.IsDeleted = true;

            return deletedUser;
        }

        public IQueryable<User> GetAsync(Expression<Func<User, bool>> predicate)
        {
            return _appDataContext.Users.Where(predicate.Compile()).AsQueryable();
        }

        public ValueTask<ICollection<User>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default)
        {
            var result = _appDataContext.Users.Where(user => ids.Contains(user.Id));

            return new ValueTask<ICollection<User>>(result.ToList());
        }

        public ValueTask<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = _appDataContext.Users.FirstOrDefault(user => user.Id == id);

            if (result == null)
                throw new Exception("User not found");

            return new ValueTask<User>(result);
        }

        public async ValueTask<User> UpdateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var updatedUser = await GetByIdAsync(user.Id);

            if (!IsValidEmailAddress(user.Email))
                throw new Exception("Email address invalid!");

            updatedUser.FirstName = user.FirstName;
            updatedUser.LastName = user.LastName;
            updatedUser.Email = user.Email;
            
            return updatedUser;
        }

        private bool IsValidEmailAddress(string emailAddress)
        {
            if (!string.IsNullOrWhiteSpace(emailAddress) && Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$"))
                return true;
            
            else 
                return false;
        }
    }
}