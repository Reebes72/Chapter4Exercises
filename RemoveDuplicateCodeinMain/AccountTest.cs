using System;

namespace RemoveDuplicateCodeinMain
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            DisplayAccount(account1);
            DisplayAccount(account2);
           
           
            //input deposit amount for account1
            Console.Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"adding {depositAmount:C} to account1 balance\n");
            account1.Deposit(depositAmount);

            // display balances
            DisplayAccount(account1);
            DisplayAccount(account2);

            //input deposit amount for account2
            Console.Write("\nEnter deposit amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount);

            // display balances
            DisplayAccount(account1);
            DisplayAccount(account2);
        }

        static void DisplayAccount(Account accountToDisplay)
        {
             Console.WriteLine(
                 $"{accountToDisplay.Name}'s balance: {accountToDisplay.Balance:C}");
        }

    }
}
