namespace PaymentAPI_Strategy_.Services
{
    public class PaymentContext //paymentcontext sẽ nhận vào một chiến lược thanh toán và thực hiện thanh toán bằng cách gọi ThanhToanDonHang(int soTien)
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public string ThanhToanDonHang(int soTien)
        {
            return _paymentStrategy.ThanhToan(soTien);
        }
    }
}
