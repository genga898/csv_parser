namespace CsvParser.Client.Models;

public class ProviderFile(
    string transactionReference,
    decimal amount,
    string status,
    decimal transactionFee,
    DateTime settlementDate,
    string processorId)
{
    private string TransactionReference { get; set; } = transactionReference;
    private decimal Amount { get; set; } = amount;
    private string Status { get; set; } = status;
    private decimal TransactionFee { get; set; } = transactionFee;
    private DateTime SettlementDate { get; set; } = settlementDate;
    private string ProcessorId { get; set; } = processorId;

    // Individual getter methods
    public string GetTransactionReference() => TransactionReference;
    public decimal GetAmount() => Amount;
    public string GetStatus() => Status;
    public decimal GetTransactionFee() => TransactionFee;
    public DateTime GetSettlementDate() => SettlementDate;
    public string GetProcessorId() => ProcessorId;
}