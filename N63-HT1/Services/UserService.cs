using N63_HT1.DataAccess;
using N63_HT1.Interfaces;
using N63_HT1.Models;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace N63_HT1.Services
{
    public class UserService : IUserService
    {
        private readonly IDataContext _dataContext;
        public UserService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async ValueTask<User> CreateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            if (!IsValidNames(user.FirstName) || !IsValidNames(user.LastName))
                throw new Exception("Invalid names!");
            if (!IsValidEmailAddress(user.EmailAddress))
                throw new Exception("Invalid emailAddress!");
            if (!IsValidPassword(user.Password))
                throw new Exception("Invalid password!");

            await _dataContext.Users.AddAsync(user, cancellationToken);

            if (saveChanges)
                await _dataContext.Users.SaveChangesAsync(cancellationToken);

            return user;
        }

        public async ValueTask<User> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var deletedUser = await GetByIdAsync(id, cancellationToken);

            await _dataContext.Users.RemoveAsync(deletedUser, cancellationToken);

            if (saveChanges)
                await _dataContext.Users.SaveChangesAsync(cancellationToken);

            return deletedUser;
        }

        public async ValueTask<User> DeleteAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var deletedUser = await GetByIdAsync(user.Id, cancellationToken);

            await _dataContext.Users.RemoveAsync(deletedUser, cancellationToken);

            if (saveChanges)
                await _dataContext.Users.SaveChangesAsync(cancellationToken);

            return deletedUser;
        }

        public IQueryable<User> Get(Expression<Func<User, bool>> predicate)
        {
            return _dataContext.Users.Where(predicate.Compile()).AsQueryable();
        }

        public ValueTask<ICollection<User>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default)
        {
            var users = _dataContext.Users.Where(user => ids.Contains(user.Id));
            return new ValueTask<ICollection<User>>(users.ToList());
        }

        public ValueTask<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var users = _dataContext.Users.FirstOrDefault(user => user.Id == id);

            if (users == null)
                throw new Exception("Bunday user mavjud emas!");

            return new ValueTask<User>(users);
        }

        public async ValueTask<User> UpdateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var updatedUser = await GetByIdAsync(user.Id, cancellationToken);

            if (!IsValidNames(user.FirstName) || !IsValidNames(user.LastName))
                throw new Exception("Invalid names!");
            if (!IsValidEmailAddress(user.EmailAddress))
                throw new Exception("Invalid emailAddress!");
            if (!IsValidPassword(user.Password))
                throw new Exception("Invalid password!");

            updatedUser.FirstName = user.FirstName;
            updatedUser.LastName = user.LastName;
            updatedUser.EmailAddress = user.EmailAddress;
            updatedUser.Password = user.Password;

            if (saveChanges)
                await _dataContext.Users.SaveChangesAsync(cancellationToken);

            return updatedUser;
        }

        private bool IsValidNames(string name)
        {
            if (!string.IsNullOrEmpty(name))
                return true;
            else
                return false;
        }
        private bool IsValidPassword(string password)
        {
            if (!string.IsNullOrEmpty(password) && password.Length >= 4)
                return true;
            else
                return false;
        }
        private bool IsValidEmailAddress(string emailAddress)
        {
            if (!string.IsNullOrEmpty(emailAddress) &&
                Regex.IsMatch(emailAddress, @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                return true;
            else
                return false;
        }
    }
}
