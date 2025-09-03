constructor
 class A
{
    int num;
    A() //Default constructor
    {
        num = 100;
    }
    public void show()
    {
        Console.Write(num);
    }
    static void Main(string[] args)
    {
        A r = new A();
        r.show();
    }
}