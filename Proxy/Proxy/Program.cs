using Proxy.Domain;
using Proxy.Interfaces;
using Proxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Account c = new Account(1, "mitocode", 100);

            IAccount accountProxy = new AccountProxy(new AccountBankB());
            accountProxy.ShowMoney(c);
            c = accountProxy.DepositeMoney(c, 50);
            c = accountProxy.RetireMoney(c, 20);
            accountProxy.ShowMoney(c);

            Console.ReadKey();
        }
    }
}
