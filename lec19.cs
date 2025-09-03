class A
{
    protected int a = 200, b = 100, c;
    public void add()
    {
        c = a + b;
        Console.WriteLine("Addition " + c);
    }
    public void sub()
    {
        c = a - b;
        Console.WriteLine("Subtraction " + c);
    }
}
class B : A
{
    public void Mul()
    {
        c = a * b;
        Console.WriteLine("Multiplication " + c);
    }
    public void dev()
    {
        c = a / b;
        Console.WriteLine("Division " + c);
    }
    static void Main(string[] args)
    {
        B r = new B();
        r.add();
        r.sub();
        r.Mul();
        r.dev();
    }
}
//------------------- Multi inhertance ---------------------//
interface A
{
    void add();
}
interface B
{
    void sub();
}
class C : A, B
{
    public void add()
    {
        int a = 10, b = 20;
        Console.WriteLine(a + b);
    }
    public void sub()
    {
        int a = 10, b = 20;
        Console.WriteLine(a - b);
    }
    static void Main()
    {
        C r = new C();
        r.add();
        r.sub();
    }
}