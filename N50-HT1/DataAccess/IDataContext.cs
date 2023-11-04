using FileBaseContext.Abstractions.Models.FileSet;
using N50_HT1.Models;

namespace N50_HT1.DataAccess;

public interface IDataContext
{
    IFileSet<User, Guid> Users { get; }
    IFileSet<Order, Guid> Orders { get; }

    ValueTask SaveChangesAsync();
}
