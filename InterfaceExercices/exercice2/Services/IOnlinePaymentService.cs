interface IOnlinePaymentService
{
    double PaymentFree(double amount);
    double Interest(double amount, int months);
}