

public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}

public class LibraryManagement
{
    public Dictionary<string, int> Books = new Dictionary<string, int>();

    public void Chekout(Guid bookId)
    {
        foreach (var book in Books)
        {
        }
    }
}