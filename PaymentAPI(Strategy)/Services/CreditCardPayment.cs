namespace PaymentAPI_Strategy_.Services
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public string ThanhToan(int soTien)
        {
            return $"Thanh toán {soTien}VND bằng thẻ tín dụng";
        }
    }
}
