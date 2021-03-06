﻿using System;
using System.Collections.Generic;

namespace Support_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = FileReader.ReadTransactions();
            var accounts = Bank.GetAccounts(transactions);
            var UpdatedAccounts = Bank.UpdatedAccounts(transactions, accounts);
        }
    }
}