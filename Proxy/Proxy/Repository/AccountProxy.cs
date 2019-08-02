using Proxy.Domain;
using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Repository
{
    public class AccountProxy : IAccount
    {
        private IAccount realAccount;

        public AccountProxy(IAccount realAccount )
        {
            this.realAccount = realAccount;
        }

        public Account RetireMoney(Account account, double mont)
        {
            if (realAccount == null)
            {
                realAccount = new AccountBankA();
                return realAccount.RetireMoney(account, mont);
            }
            else
            {
                return realAccount.RetireMoney(account, mont);
            }
        }

        public Account DepositeMoney(Account account, double mont)
        {
            if (realAccount == null)
            {
                realAccount = new AccountBankA();
                return realAccount.DepositeMoney(account, mont);
            }
            else
            {
                return realAccount.DepositeMoney(account, mont);
            }
        }    

        public void ShowMoney(Account account)
        {
            if (realAccount == null)
            {
                realAccount = new AccountBankA();
                realAccount.ShowMoney(account);
            }
            else
            {
                realAccount.ShowMoney(account);
            }
        }
    }
}
