using FileBaseContext.Abstractions.Models.FileSet;
using N62_A_T1.DTOs;
using N62_A_T1.Models;

namespace N48_HT1.DataAccess
{
    public interface IDataContext
    {
        IFileSet<User, Guid> Users { get; }

        ValueTask SaveChangesAsync();
    }
}
