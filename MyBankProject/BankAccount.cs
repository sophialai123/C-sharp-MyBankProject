using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankProject
{
    public class BankAccount
    {
        //properites
        public string Number { get; }

        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumerSeed = 123456;


        //defie a list of transaction
        private List<Transaction> allTransactions = new List<Transaction>();




        //need constructor to open account
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            //make a deposit

            MakeDeposit(initialBalance, DateTime.Now, "Intital Balance");

            //Number is string
            this.Number = accountNumerSeed.ToString();
            //each account has different account number
            accountNumerSeed++;
        }


        //methods
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }


            var deposit = new Transaction(amount, date, note);

            //add new deposite infor in to list
            allTransactions.Add(deposit);

        }


        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this widthdrawal");
            }

            // -amount is a negative amount
            var widthdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(widthdrawal);


        }

        //Challenge - log all transactions

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            decimal balance = 0;

            // \t is the tap to make a space, table header 
            report.AppendLine("Date\t\tAmount\t\tBalance\t\tNote\n");

            foreach (var item in allTransactions)
            {
                balance += item.Amount;


                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t\t{balance}\t\t{item.Notes}");
            }

            return report.ToString();
        }




    }
}
