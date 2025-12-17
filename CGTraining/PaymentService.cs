public class PaymentService
{
    public bool ProcessPayment(Payment payment)
    {
        return payment.Amount > 0;
        if (payment == null)
            return false;

        return true;
    }

}

public class Payment
{
    public double Amount { get; set; }
}