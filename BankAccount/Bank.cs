using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Bank
    {
        public Account[] bankAccounts;
        public Bank()
        {
            bankAccounts = new Account[0];
        }
        public void Add(Account account1)
        {
            Array.Resize(ref bankAccounts, bankAccounts.Length + 1);
            bankAccounts[bankAccounts.Length - 1] = account1;
        }
        public Account GetBankAccountByOwner(string OwnerName)
        {
            Account bankAccount = null;
            for(int i = 0; i < bankAccounts.Length; i++)
            {
                if (bankAccounts[i].OwnerName==OwnerName)
                {
                    bankAccount = bankAccounts[i];
                    break;
                }
                else
                {
                    Console.WriteLine("bele bir istifadeci adi yoxdur");
                }
            }
            return bankAccount;
        }
        public void GetBankAccountsCount()
        {
            Console.WriteLine(bankAccounts.Length);
        }
        public void DeleteBankAccount(string OwnerName)
        {
            Account bankaccount = null;
            for(int i =0;i<bankAccounts.Length;i++)
            {
               
                if (bankAccounts[i].OwnerName==OwnerName)
                {
                    bankAccounts[bankAccounts.Length - 1] = bankaccount;                                                                               
                    Array.Resize(ref bankAccounts, bankAccounts.Length - 1);

                }
            }
        }
    }
}
