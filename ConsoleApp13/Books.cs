namespace ConsoleApp13;

public class Books
{
    public string Title { get; set; }
    public int Pagecount { get; set; }
    public string Author { get; set; }

    public Books(string title, int pagecount, string author)
    {
        Title = title;
        Pagecount = pagecount;
        Author = author;
    }

    public override string ToString()
    => $"Title:{Title}\nPageCount:{Pagecount}\nAuthor:{Author}\n";
}
