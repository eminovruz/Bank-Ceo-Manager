namespace Bank_Ceo_Manager;


public class Operations
{
    public Guid Id { get; } = Guid.NewGuid();
    public string? OperationName { get; set; }
    public DateTime Time { get; set; }
}
