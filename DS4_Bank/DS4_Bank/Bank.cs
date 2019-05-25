using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DS4_Bank
{
    public class Bank
    {
        private AccountData _account;
        private static object obj = new object();

        private Bank()
        {
            _account = new AccountData();
        }

        public AccountData GetAccount()
        {
            return _account;
        }

        public static Bank _instance;
        public static Bank BankInstance()
        {
            if(_instance == null)
            {
                lock (obj)
                {
                    if(_instance == null)
                        _instance = new Bank();
                }
            }
            return _instance;
        }
    }

    [DataContract]
    public class AccountData
    {
        [DataMember]
        public double Sum { get; private set; }
        
        public void Withdraw(double s)
        {
            Sum -= s;
        }

        public void Deposit(double s)
        {
            Sum += s;
        }
    }
}