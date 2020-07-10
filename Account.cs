using System;
using System.IO;
using System.Collections.Generic;

namespace Support_Bank
{
    public class Account
    {
        public string Name;
        public List<Transactions> Owed;
        public List<Transactions> Owe;

        public Account(string name)
        {
            Name = name;
            Owed = new List<Transactions>();
            Owe = new List<Transactions>();

        }

        public decimal GetTotalAmount()
        {
            var totalOwed = new Decimal(0);
            foreach(var currentOwedTransaction in Owed)
            {
                totalOwed = totalOwed + currentOwedTransaction.amount;
            }
            foreach(var currentOweTransaction in Owe)
            {
                totalOwed = totalOwed - currentOweTransaction.amount;
            }
            return totalOwed;

        }
    
    }
}    