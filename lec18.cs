// Encapsulation
class A
{
    private int atmPIN;
    public int getReturn()
    {
        return atmPIN;
    }
    public void setValue(int pin)
    {
        atmPIN = pin;
    }
}
class B
{
    public static void Main(string[] args)
    {
        A r = new A();
        r.setValue(4567);
        Console.Write("ATM" + r.getReturn());
        // Console.Write(r.atmPIN);
    }
}