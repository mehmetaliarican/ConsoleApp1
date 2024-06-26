﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using EmreNameSpace;

namespace ConsoleApp1.Models.Generated
{
    public partial class BankAccountTransaction : BaseEmre
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Balance { get; set; }
        public string Description { get; set; }
        public DateTime? Time { get; set; }
        public int? BankId { get; set; }
        public bool LoadedToAccount { get; set; }
        public long? LoadedAccountId { get; set; }
        public string BankAccountId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? NetBalance { get; set; }
        public string OperationGroup { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual BankAccount BankAccount { get; set; }
        public virtual Account LoadedAccount { get; set; }
    }
}