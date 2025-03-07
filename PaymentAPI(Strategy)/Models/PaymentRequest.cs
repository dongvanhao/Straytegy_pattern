namespace PaymentAPI_Strategy_.Models
{
    public class PaymentRequest
    {
        public string PaymentMethod { get; set; } = string.Empty;
        public int Amount { get; set; }
    }
}
