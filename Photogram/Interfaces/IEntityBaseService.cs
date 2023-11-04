﻿using System.Linq.Expressions;

namespace Photogram.Interfaces
{
    public interface IEntityBaseService<T> where T : class
    {
        IQueryable<T> GetAsync(Expression<Func<T, bool>> predicate);

        ValueTask<ICollection<T>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default);

        ValueTask<T> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        ValueTask<T> CreateAsync(T entity, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<T> UpdateAsync(T entity, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<T> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<T> DeleteAsync(T entity, bool saveChanges = true, CancellationToken cancellationToken = default);
    }
}
