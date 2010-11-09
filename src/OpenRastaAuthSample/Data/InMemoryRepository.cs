using System;
using OpenRastaAuthSample.Resources;

namespace OpenRastaAuthSample.Data
{
    public class InMemoryRepository : IBankAccountRepository
    {
        private Random rng = new Random();

        public BankAccountResource GetFor(string username)
        {
            var randomAmount = rng.NextDouble() * 1000;
            return new BankAccountResource(username, randomAmount);
        }
    }
}