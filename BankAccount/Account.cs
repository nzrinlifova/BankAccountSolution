
namespace BankAccount
{
    class Account
    {
        private decimal _balance;
        public decimal balance
        {
            get { return _balance; }
        }
        private int _accountnumber;
        private int AccountNumber
        {
            get { return _accountnumber; }
        }
        public string OwnerName;
        public Account(int AccountNumber,string ownername,decimal Balance)
        {
            _accountnumber = AccountNumber;
            OwnerName = ownername;
            if (Balance >= 0)
                _balance = Balance;
           
        }
        public void Deposit (decimal depositamount)
        {
            if (depositamount>0)
            {
                _balance += depositamount;
                Console.WriteLine($"{depositamount} azn ugurla kocuruldu, umumi balans:{_balance}");
            }
            else
            {
                Console.WriteLine("deposit meblegi 1 AZN-den kicik ola bilmez");
            }
        }
        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount <= 0)
            {
                Console.WriteLine("Çıxarma məbləği 0 AZN-dən böyük olmalıdır.");
                return;
            }
            if (withdrawAmount <= _balance)
            {
                _balance -= withdrawAmount;
                Console.WriteLine($"{withdrawAmount} AZN çıxarıldı. Qalan balans: {_balance}.");
            }
            else
            {
                Console.WriteLine("Balansda kifayət qədər vəsait yoxdur.");
            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"ID:{AccountNumber} Istifadeci adi:{OwnerName},Cari balans:{balance}.");
        }
        public void TransferFunds(Account recipient, decimal amount)
        {
            recipient.Deposit(amount);
            Console.WriteLine($"{recipient} sexsine {amount} AZN qeder pul kocuruldu.");
        }



      
    }
}
