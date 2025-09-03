
class Player
{
    public string name = "Muzamil";
    public int health = 49;
    public void setHealth(int h)
    {
        health = h;
    }

}
static void Main(string[] args)
{ //  OOPs - Classes and Objects
    player tommy = new Player();
    Console.WriteLine(tommy.health);
    tommy.setHealth(57);
    Console.ReadLine();
}
do not repeat yourself 