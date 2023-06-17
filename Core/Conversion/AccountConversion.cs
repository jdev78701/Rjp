using Core.Model;

namespace Core.Entities
{
    public partial class Account
    {
        public static implicit operator AccountModel(Account account)
        {

            AccountModel accountDto = new AccountModel();
            accountDto.AccountId = (int)account?.AccountId;
            accountDto.Balance = account?.Balance;
            accountDto.CustomerFirstName= account?.Customer?.FirstName;
            accountDto.CustomerId = (int)account?.Customer?.CustomerId;
            accountDto.CustomerLastName = account?.Customer?.LastName;
            return accountDto;
        }

        public static implicit operator Account(AccountModel accountModel)
        {

            Account account = new Account();
            account.AccountId = (int)accountModel?.AccountId;
            account.Balance = accountModel?.Balance;
            account.CustomerId = (int)accountModel?.CustomerId;
            return account;
        }
    }
}
