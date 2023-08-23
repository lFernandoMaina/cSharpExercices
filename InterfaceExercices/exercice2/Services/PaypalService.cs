class PaypalService : IOnlinePaymentService
{
    private const double FreePercentage = 0.02;
    private const double MonthlyInterest = 0.01;

    public double Interest(double amount, int months)
    {
        return amount * MonthlyInterest * months;
    }

    public double PaymentFree(double amount)
    {
        return amount * FreePercentage;
    }

}