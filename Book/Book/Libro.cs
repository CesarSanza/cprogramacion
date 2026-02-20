namespace Book;

public class Libro
{
    private string title;
    private string author;
    private int pages;
    private bool open;
    private bool closed;
    public Libro()
    {
        title = "Big Boss";
        author = "Charlie";
        pages = 200;
        open = false;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Pages: " + pages);

    }
    public void Open()
    {
        open = true;
        Console.WriteLine("El libro \"" + title + "\"se abrio.");
    }

    public void Close() 
    {
        open = false;
        Console.WriteLine("El libro \"" + title + "\" se cerro.");
    }
}


