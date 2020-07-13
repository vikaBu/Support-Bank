using System;

namespace Support_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = FileReader.ReadTransactions();
            var accounts = Bank.GetAccounts(transactions);
            
            Console.WriteLine(accounts);
        }
    }
}