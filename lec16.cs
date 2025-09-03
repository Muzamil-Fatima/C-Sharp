class Mobile
{
    int price;
    String storage;
    String color;
    public void calling()
    {
        Console.Write("Voice Msg");
    }
    public void chatting()
    {
        Console.Write("Text Msg");
    }
    public void Music()
    {
        Console.Write("Song.......");
    }
    static void Main(string[] args)
    {
        Mobile m = new Mobile();
        m.price = 10000;
        m.storage = "16GB";
        m.color = "Black";
        Console.WriteLine(m.price);
        Console.WriteLine(m.storage);
        Console.WriteLine(m.color);
        m.calling();
        m.chatting();
        m.Music();
    }
}