using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Domain
{
    public class Account
    {
        private int IdAccount;
        private string User;
        private double InitialBalance;

        public Account(int idAccount, string user, double initialBlance)
        {
            this.IdAccount = idAccount;
            this.User = user;
            this.InitialBalance = initialBlance;
        }

        public int GetIdAccount()
        {
            return IdAccount;
        }

        public void SetIdAccount(int idAccount)
        {
            this.IdAccount = idAccount;
        }

        public string GetUser()
        {
            return User;
        }

        public void SetUser(string user)
        {
            this.User = user;
        }
        
        public double GetInitialBalance()
        {
            return InitialBalance;
        }

        public void SetInitialBalance(double initialBalance)
        {
            this.InitialBalance = initialBalance;
        }
    }
}
