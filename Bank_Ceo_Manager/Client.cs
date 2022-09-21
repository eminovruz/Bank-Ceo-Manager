namespace Bank_Ceo_Manager;

public class Client:Peron
{
    public Credit Credit { get; set; }
    public string _liveadress { get; set; }
    public string _livework_adress { get; set; }
    
    public Client() { }

    public Client(string name, string surname, int age,string position, double salary, Credit credit,string liveadress,string liveworkadres)
        :base( name,  surname,  age, position,  salary)
    {
        Credit = credit;
        _liveadress = liveadress;
        _livework_adress = liveworkadres;
    }

    public override void show()
    {
        base.show();
        Console.WriteLine($"\nLive Adress -- {_liveadress}\nWork Adress -- {_livework_adress}"); 
    }
}
