namespace Bank_Ceo_Manager;

public class Ceo:Peron,Iorginze,Icontrol,Imakemeeting
{
    public Ceo() { }

    public Ceo(string name, string surname, int age, string position, double salary)
        : base(name, surname, age, position, salary) { }

    public void Control()
    {
        Console.WriteLine("Ceo is control");
    }

    public void Makemeeting()
    {
        Console.WriteLine("Ceo is Make meeting");
    }

    void Iorginze.Organize()
    {
        Console.WriteLine("Ceo is Organize");
    }
}
