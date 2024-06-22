namespace BreadBudget.Entities;

public class Category
{
    public int Id { get; set; }

    public required string Name { get; set; }

    /// <summary>
    /// The IDs of the Transactions that belong to this Category.
    /// </summary>
    public List<int> TransactionIds { get; set; } = [];

    /// <summary>
    /// The ID of the Account that this Category belongs to.
    /// </summary>
    public required int AccountId { get; set; }
}
