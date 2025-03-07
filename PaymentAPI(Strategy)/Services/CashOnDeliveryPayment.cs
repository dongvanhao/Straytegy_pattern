namespace PaymentAPI_Strategy_.Services
{
    public class CashOnDeliveryPayment : IPaymentStrategy
    {
        public string ThanhToan(int soTien)
        {
            return $"Thanh toán {soTien}VND bằng tiền mặt khi nhận hàng";
        }
    }
}
