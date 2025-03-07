namespace PaymentAPI_Strategy_.Services
{
    public class PayPalPayment : IPaymentStrategy
    {
        public string ThanhToan(int soTien)
        {
            return $"Thanh toán {soTien}VND bằng PayPal";
        }
    }
}
