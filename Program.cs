using System.Linq;
using System.Collections.Generic;
using System;


namespace Support_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = FileReader.ReadTransactionsFromFile();

            Console.WriteLine(transactions);

            var accounts = GetAccounts(transactions);

            var amounts = accounts.Select(account => account.GetTotalAmount());
            
        }

        static List<Account> GetAccounts(List<Transactions> Transactions)
        {
            var names = getNames(Transactions);
            var allaccounts = new List<Account>();
            foreach(var currentName in names)
            {
                var currentAccount = new Account(currentName);
                allaccounts.Add(currentAccount);

            }
            return allaccounts; 
        }

        static HashSet<string> getNames(List<Transactions> transactions)
        {
            var allNames = new HashSet<string>();

            foreach(var currentTransaction in transactions)
            {
                allNames.Add(currentTransaction.to);
                allNames.Add(currentTransaction.from);
            }
            return allNames;
        }
    }
}
