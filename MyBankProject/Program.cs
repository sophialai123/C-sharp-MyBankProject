using System;

namespace MyBankProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Sophia", 1000);
            Console.WriteLine($"{account.Owner}'s Account Number is: {account.Number} and the balance is ${account.Balance}.\n ");

            //withdrwal money
            account.MakeWithdrawal(200, DateTime.Now, "Shoes");
            Console.WriteLine($"{account.Owner}'s Account Number is: {account.Number} and the balance is ${account.Balance}.\n ");


            // Test that the initial balances must be positive.
            //BankAccount invalidAccount;

            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);

            //}
            ////catch the exception
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance.");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}


            //withdrwal money
            account.MakeWithdrawal(500, DateTime.Now, "Dress");
            Console.WriteLine($"{account.Owner}'s Account Number is: {account.Number} and the balance is ${account.Balance}.\n ");

            // Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw.");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw.");
            //    Console.WriteLine(e.ToString());
            //}



            //get all the account history

            Console.WriteLine(account.GetAccountHistory());



        }
    }
}
