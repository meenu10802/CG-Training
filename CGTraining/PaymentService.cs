public class PaymentService
{
    public bool ProcessPayment(Payment payment)
    {
        return true;
    }
}

public class Payment
{
    public double Amount { get; set; }
}