using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DS4_Bank
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class BankService : IBankService
    {
        public void SelectAccount(int i)
        {
            Bank.BankInstance().SelectAccount(i);
        }

        public double ShowInDinars()
        {
            return Bank.BankInstance().GetAccount().Sum * 120;
        }

        public List<string> ShowLog()
        {
            return Bank.BankInstance().GetLog();
        }

        public void UpdateBalance(double d, string name, double coef)
        {
            if (name == "euro")
            {
                Bank.BankInstance().GetAccount().Deposit(d);
                Bank.BankInstance().LogMessage("Napravljen depozit od: " + d.ToString());
            }
            else
            {
                Bank.BankInstance().GetAccount().Deposit(d * coef);
                Bank.BankInstance().LogMessage("Napravljen depozit od: " + (d*coef).ToString());
            }
        }

        public bool Withdraw(double d)
        {
            if (Bank.BankInstance().GetAccount().Sum > (d / 120))
            {
                Bank.BankInstance().GetAccount().Withdraw(d / 120);
                Bank.BankInstance().LogMessage("Preuzeta suma: " + d.ToString());
                return true;
            }
            Bank.BankInstance().LogMessage("Pokusaj preuzimanja sume: " + d.ToString());
            return false;
        }
    }
}
