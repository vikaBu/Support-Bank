﻿using System;
using System.IO;
using System.Collections.Generic;

namespace Support_Bank
{
    class FileReader
    {
        public static List <Transactions> ReadTransactionsFromFile()
        {
            var transactions = new List<Transaction>();
            var csvLines = File.ReadAllLines("Transactions.csv").Skip(1);
            foreach(var line in csvLines)
            {
                var parts = line.Split(",");

                var date = parts[0];
                var from = parts[1];
                var to = parts[2];
                var narrative = parts[3];
                var amount = parts[4];

                Console.WriteLine(parts);

            }
        }
    }
    
    
}
