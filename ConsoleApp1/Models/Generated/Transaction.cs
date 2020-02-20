﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using EmreNameSpace;

namespace ConsoleApp1.Models.Generated
{
    public partial class Transaction : BaseEmre
    {
        public Transaction()
        {
            FraudRuleTransections = new HashSet<FraudRuleTransection>();
            InverseParentTransaction = new HashSet<Transaction>();
            Invoices = new HashSet<Invoice>();
        }

        public long Id { get; set; }
        public bool Active { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public long? CreatorId { get; set; }
        public long? UpdateId { get; set; }
        public bool IsConfirmed { get; set; }
        public long? ConfirmId { get; set; }
        public DateTime? ConfirmAt { get; set; }
        public double Balance { get; set; }
        public double Amount { get; set; }
        public string Comment { get; set; }
        public string Ip { get; set; }
        public string RefNo { get; set; }
        public string QueryKey { get; set; }
        public bool IsScandedForFraud { get; set; }
        public bool IsActionTakedForFraud { get; set; }
        public DateTime? SeenDate { get; set; }
        public int? BankTransactionStatus { get; set; }
        public long? MoneyTransferBankId { get; set; }
        public long? ParentTransactionId { get; set; }
        public long TransactionTypeId { get; set; }
        public long TransactionChanelId { get; set; }
        public long AccountId { get; set; }
        public long? ReceiptId { get; set; }
        public long? InvoiceId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Person Confirm { get; set; }
        public virtual Person Creator { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Bank MoneyTransferBank { get; set; }
        public virtual Transaction ParentTransaction { get; set; }
        public virtual TransactionChanel TransactionChanel { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public virtual Person Update { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual ICollection<FraudRuleTransection> FraudRuleTransections { get; set; }
        public virtual ICollection<Transaction> InverseParentTransaction { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}