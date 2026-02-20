using Book;

class Example
{
    static void Main(string[] args)
    {
        Libro myBook = new Libro();
        myBook.ShowInfo();
        myBook.Open();               
        myBook.Close();
    }
}