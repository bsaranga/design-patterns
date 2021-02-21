
namespace dependency_inversion
{
    public class BankAccount : ITransferSource, ITransferDestination
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string acc, decimal bl)
        {
            AccountNumber = acc;
            Balance = bl;
        }

        public void AddFunds(decimal value)
        {
            Balance += value;
        }

        public void RemoveFunds(decimal value)
        {
            Balance -= value;
        }
    }
}
