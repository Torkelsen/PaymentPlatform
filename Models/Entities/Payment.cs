namespace PaymentPlatform.Models.Entities;

public class Payment : BaseEntity
{
    public Guid Provider_Id { get; set; }
    public required PaymentProvider Provider { get; set; }
    public decimal Amount { get; set; }
    public string? Currency { get; set; }
    public string? Status { get; set; }
    public string? ReferenceCode { get; set; }
}
