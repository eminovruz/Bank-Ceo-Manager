namespace Bank_Ceo_Manager;


public class Manager : Peron, Iorginze,IcalculateSalary
{
    public void Calculate()
    {
        Console.WriteLine("Calculate salary");
    }

    public void Organize()
    {
        Console.WriteLine("Manager is organize");
    }

}
