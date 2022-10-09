using System;
namespace MyBankProject
{
    public class Transaction
    {

        //properites

        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        //constructor
        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }



    }
}
