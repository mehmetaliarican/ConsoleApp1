﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using EmreNameSpace;

namespace ConsoleApp1.Models.Generated
{
    public partial class Bank : BaseEmre
    {
        public Bank()
        {
            BankAccounts = new HashSet<BankAccount>();
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Logo { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}