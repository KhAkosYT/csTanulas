using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProbalkozas
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string Owner) {
            this.Owner = Owner;
            this.AccountNumber = Guid.NewGuid();
            this.Balance = 0;
            
        }

        public string deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return string.Format("Nem tudsz %d Ft-ot betenni a bankba!", amount);
            }

            Balance += amount;
            return "Sikeres feltoltes!";
        }

        public string withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                return string.Format("Nem tudsz %d Ft-ot kivenni! Nincs eleg penz az egyenlegeden!", amount);
            }

            Balance -= amount;
            return "sikeres keszpenzfelvetel!";
        }
    }
}
