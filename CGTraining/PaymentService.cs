public class PaymentService
{
    public bool ProcessPayment(Payment payment)
    {
        return payment.Amount > 0;
    }

}

public class Payment
{
    public double Amount { get; set; }
}