// Module # 3 => object and classes 
// class name is our data type .Class ki matad sy hum apna data type bana sakty hai aur object ki madat sy  
class Book
{
    public string? title;
    public string? author;
    public int pages;

    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.title = " Harry Potter";
        book1.author = "JK Rowling";
        book1.pages = 400;

        Book book2 = new Book();
        book2.title = " Lord Of the Rings ";
        book2.author = "Tolkein";
        book2.pages = 700;
        Console.WriteLine(book1.title);
        Console.WriteLine(book2.title);
        Console.WriteLine(book1.author);
        Console.WriteLine(book2.author);
        Console.WriteLine(book1.pages);
        Console.WriteLine(book2.pages);
        Console.ReadLine();
    }
}