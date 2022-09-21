namespace Bank_Ceo_Manager;


class Program
{
    static void Main()
    {
        Client client = new Client("nihat", "akremi", 18, "Programmer", 3000, new Credit(100, 0, 2, 20), "bulbul 18", "kanada");
        client.show();
    }
}