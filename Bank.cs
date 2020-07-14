using System.Collections.Generic;

namespace Support_Bank
{
    public class Bank
    {
        public static List<Account> GetAccounts(List<Transaction> transactions)
        {
            var names = GetUniqueNames(transactions);

            var accounts = new List<Account>();

            foreach (var name in names)
            {
                var account = new Account(name);
                accounts.Add(account);
            }

            return accounts;
        }

        private static HashSet<string> GetUniqueNames(List<Transaction> transactions)
        {
            var names = new HashSet<string>();

            foreach (var transaction in transactions)
            {
                names.Add(transaction.from);
                names.Add(transaction.to);
            }

            return names;
        }
        public static List<Account> UpdatedAccounts(List<Transaction> transactions, List<Account> accounts)
        {
            foreach (var transaction in transactions)
            {
                var account = FindAccount(transaction.from, accounts);
                account.outgoingTransactions.Add(transaction);

            }

             foreach (var transaction in transactions)
            {
                var account = FindAccount(transaction.to, accounts);
                account.incomingTransactions.Add(transaction);

            }
                return accounts;
        }
        
        public static Account FindAccount(string name, List <Account> accounts)
        {
            foreach(var account in accounts)
            {
                if (name == account.name)
                {
                    return account;

                }
                    
            }
            return null;
        }


    }
}