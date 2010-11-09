namespace OpenRastaAuthSample.Resources
{
    public class BankAccountResource
    {
        public string AccountHolder { get; private set; }
        public double Balance { get; private set; }

        public BankAccountResource(string accountHolder, double initalBalance)
        {
            AccountHolder = accountHolder;
            Balance = initalBalance;
        }
    }
}