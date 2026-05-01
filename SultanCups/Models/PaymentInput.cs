namespace SultanCups.Models
{
    public class PaymentInput
    {
        public string method { get; set; } = "cash";

        public decimal amount { get; set; } = 0;
    }
}