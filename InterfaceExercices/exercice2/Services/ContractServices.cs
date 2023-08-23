class ContractService
{
    private IOnlinePaymentService _onlinePaymentService;

    public ContractService(IOnlinePaymentService onlinePaymentService)
    {
        _onlinePaymentService = onlinePaymentService;
    }

    public void ProcessContract(Contract contract, int months)
    {
        var basicQuota = contract.TotalValue / months;

        for (int i = 0; i <= months; i++)
        {
            var date = contract.Date.AddMonths(i);
            var updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
            var fullQuota = basicQuota + _onlinePaymentService.PaymentFree(updateQuota);
            contract.AddInstallment(new Installment(date, fullQuota));
        }
    }
}