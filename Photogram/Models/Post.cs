using FileBaseContext.Abstractions.Models.Entity;

namespace Photogram.Models
{
    public class Post : IFileSetEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Guid UserId { get; set; }
    }
}
