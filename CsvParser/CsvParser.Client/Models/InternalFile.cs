namespace CsvParser.Client.Models;

public class InternalFile(
    string transactionReference,
    decimal amount,
    string status,
    string customerId,
    DateTime timestamp,
    string description)
{
    private string TransactionReference { get; set; } = transactionReference;
    private decimal Amount { get; set; } = amount;
    private string Status { get; set; } = status;
    private string CustomerId { get; set; } = customerId;
    private DateTime Timestamp { get; set; } = timestamp;
    private string Description { get; set; } = description;

    // Individual getter methods
    public string GetTransactionReference() => TransactionReference;
    public decimal GetAmount() => Amount;
    public string GetStatus() => Status;
    public string GetCustomerId() => CustomerId;
    public DateTime GetTimestamp() => Timestamp;
    public string GetDescription() => Description;
}