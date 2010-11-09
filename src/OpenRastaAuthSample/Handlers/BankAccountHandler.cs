using OpenRasta.Security;
using OpenRasta.Web;
using OpenRastaAuthSample.Data;

namespace OpenRastaAuthSample.Handlers
{
    [RequiresAuthentication] // makes sure that there has been an authentication process before invoking ALL members, can be applied to individual methods if required
    public class BankAccountHandler
    {
        // will be automatically injected by DI in OpenRasta
        public ICommunicationContext Context { get; set; }

        private readonly IBankAccountRepository _repository;

        public BankAccountHandler(IBankAccountRepository repository)
        {
            _repository = repository;
        }

        public OperationResult Get()
        {
            var username = Context.User.Identity.Name;

            var bankAccount = _repository.GetFor(username);

            return new OperationResult.OK(bankAccount);
        }
    }
}