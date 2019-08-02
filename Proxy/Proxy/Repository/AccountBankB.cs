using Proxy.Domain;
using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Repository
{
    public class AccountBankB : IAccount
    {
        public Account RetireMoney(Account account, double mont)
        {
            double currentMoney = account.GetInitialBalance() - mont;
            account.SetInitialBalance(currentMoney);
            Console.WriteLine("Current Money:" + account.GetInitialBalance());
            return account;
        }

        public Account DepositeMoney(Account account, double mont)
        {
            double currentMoney = account.GetInitialBalance() + mont + 0.20;
            account.SetInitialBalance(currentMoney);
            Console.WriteLine("Current Money:" + account.GetInitialBalance());
            return account;
        }

        public void ShowMoney(Account account)
        {
            Console.WriteLine("Current Money:" + account.GetInitialBalance());
        }
    }
}
