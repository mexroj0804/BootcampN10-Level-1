using FileBaseContext.Abstractions.Models.FileSet;
using N63_HT1.Models;

namespace N63_HT1.DataAccess;

public interface IDataContext
{
    IFileSet<User, Guid> Users { get; }

    ValueTask SaveChangesAsync();
}
