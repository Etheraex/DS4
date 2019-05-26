using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DS4_Bank
{
    public class Bank
    {
        private List<AccountData> _accounts;
        private List<string> _log;
        private static object obj = new object();
        private int _selected = 0;

        private Bank()
        {
            _accounts = new List<AccountData>();
            // 5 naloga samo za simulaciju
            // trebalo bi da postoji nacin za kreiranje naloga i brisanje ali nope
            _accounts.Add(new AccountData());
            _accounts.Add(new AccountData());
            _accounts.Add(new AccountData());
            _accounts.Add(new AccountData());
            _accounts.Add(new AccountData());

            _log = new List<string>();
        }

        public void SelectAccount(int i)
        {
            _selected = i;
        }

        public AccountData GetAccount()
        {
            return _accounts[_selected];
        }

        public void LogMessage(string message)
        {
            _log.Add(message + " nad nalogom: " + _selected.ToString());
        }

        public List<string> GetLog()
        {
            return _log;
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