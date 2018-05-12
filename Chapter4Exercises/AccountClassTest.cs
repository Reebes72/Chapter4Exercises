using Chapter4Exercises;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClassModification49{




    class AccountClassTest
{


    static void Main(string[] args)
    {
            AccountClassMod account1 = new AccountClassMod("Jane Green", 50.00m);
            AccountClassMod account2 = new AccountClassMod("John Blue", -7.53m);

            Console.WriteLine(
                $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
                $"{account2.Name}'s balance: {account2.Balance:C}");


            //input deposit amount for account1
            Console.Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"adding {depositAmount:C} to account1 balance\n");
            account1.Deposit(depositAmount);

            // display balances
            Console.WriteLine(
                $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
                $"{account2.Name}'s balance: {account2.Balance:C}");

            //input deposit amount for account2
            Console.Write("\nEnter deposit amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount);

            // display balances
            Console.WriteLine(
                $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
                $"{account2.Name}'s balance: {account2.Balance:C}");

            //input withdraw amount for account1
            Console.WriteLine("Enter withdrawal amount for account1: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"withdrawing {withdrawAmount:C} from account1 balance\n");
            account1.Withdraw(withdrawAmount);

            // display balances
            Console.WriteLine(
                $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
                $"{account2.Name}'s balance: {account2.Balance:C}");

            //input withdraw amount for account2
            Console.WriteLine("Enter withdrawal amount for account2: ");
            withdrawAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"withdrawing {withdrawAmount:C} from account2 balance\n");
            account2.Withdraw(withdrawAmount);

            // display balances
            Console.WriteLine(
                 $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
                $"{account2.Name}'s balance: {account2.Balance:C}");

        }


    }
}
