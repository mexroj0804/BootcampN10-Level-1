using Photogram.DataAccess;
using Photogram.Interfaces;
using Photogram.Models;
using System.Linq.Expressions;

namespace Photogram.Services
{
    public class PostService : IEntityBaseService<Post>
    {
        private readonly IDataContext _appDataContext;
        
        public PostService(IDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public ValueTask<Post> CreateAsync(Post entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Post> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Post> DeleteAsync(Post entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Post> GetAsync(Expression<Func<Post, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ICollection<Post>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Post> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Post> UpdateAsync(Post entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
