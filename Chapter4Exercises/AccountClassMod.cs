using System;

namespace Chapter4Exercises
{
     class AccountClassMod
    {
        public string Name { get; set; }
        private decimal balance;

        public AccountClassMod(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }


        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if(value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if(depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if(withdrawAmount < this.Balance && withdrawAmount > 0.0m)
            {
                Balance = Balance - withdrawAmount;
            }
            else if (withdrawAmount > this.Balance) 
            {
                Console.WriteLine("Withdraw Amount has exceeded the balance.");
            }
        }
        
    }
}
