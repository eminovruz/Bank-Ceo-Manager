namespace Bank_Ceo_Manager;

public class Peron
{
    Guid _id { get; set; } = Guid.NewGuid();
    string _name { get; set; }
    string _surname { get; set; }
    int _age { get; set; }
    string _position { get; set; }
    double _salary { get; set; }

    public Peron() { }

    public Peron(string name,string surname,int age, string position,double salary)
    {
        _name = name;
        _surname = surname;
        _age = age;
        _position = position;
        _salary = salary;
    }

    virtual public void show()
    {
        Console.WriteLine($"Name -- {_name}\nSurname -- {_surname}\nAge -- {_age}\nPosition -- {_position}\nSalary -- {_salary}");
    }
}

