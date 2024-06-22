namespace BreadBudget.Entities;

/// <summary>
/// A financial account that holds money.
/// </summary>
public class Account
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public decimal Balance { get; set; }

    public List<int> TransactionIds { get; set; } = [];

    public List<int> CategoryIds { get; set; } = [];
}
