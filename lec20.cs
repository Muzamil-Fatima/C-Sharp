//Ploymorphism
class A
{
    int a = 10, b = 20;
    public void add()
    {
        int sum = a + b;
        Console.WriteLine(sum);
    }
    public void add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine(sum);
    }
}
class B
{
    public static void Main()
    {
        A r = new A();
        r.add();
        r.add(40, 60);
    }
}
// ------------ Run- Time polymorphism-------------------------//
class A
{
    public void show()
    {
        Console.WriteLine("A Class");
    }
}
class B : A
{
    public void show()
    {
        base.show(); // base show likhny sy phely is ki base may chala jaye ga 
        Console.WriteLine("B Class");
    }
}
class M
{
    public static void Main()
    {
        B r = new B();
        r.show();
    }
}