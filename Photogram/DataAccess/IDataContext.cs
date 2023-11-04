using FileBaseContext.Abstractions.Models.FileSet;
using Photogram.Models;

namespace Photogram.DataAccess
{
    public interface IDataContext
    {
        IFileSet<User, Guid> Users { get; }

        ValueTask SaveChangesAsync();
    }
}
