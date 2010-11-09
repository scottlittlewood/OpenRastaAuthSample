using OpenRastaAuthSample.Resources;

namespace OpenRastaAuthSample.Data
{
    public interface IBankAccountRepository
    {
        BankAccountResource GetFor(string username);
    }
}