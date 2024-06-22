namespace BreadBudget.Entities;

public class Transaction
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public required DateTime Date { get; set; }

    public int CategoryId { get; set; }

    public required int AccountId { get; set; }

}
