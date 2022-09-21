namespace Bank_Ceo_Manager;


public class Worker:Peron
{
    
    TimeOnly _start_work { get; set; }
    TimeOnly _end_work { get; set; }
    public Operations[]? Operation { get; set; } = null;

    public Worker(string name, string surname, int age, string position, double salary, TimeOnly start_work, TimeOnly end_work, Operations[]? operations = null)
        : base(name, surname, age, position, salary)
    {
        
        _start_work = start_work;
        _end_work = end_work;
        Operation = operations;
    }

    public override void show()
    {
        Console.WriteLine($"{base.show}\nStar Work -- {_start_work}\nEnd Work -- {_end_work}");
    }
}
