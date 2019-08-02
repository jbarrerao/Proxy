using Proxy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Interfaces
{
    public interface IAccount
    {
        Account RetireMoney(Account account, double mont);

        Account DepositeMoney(Account account, double mont);

        void ShowMoney(Account account);
    }
}
