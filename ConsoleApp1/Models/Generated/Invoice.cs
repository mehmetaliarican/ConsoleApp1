﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using EmreNameSpace;

namespace ConsoleApp1.Models.Generated
{
    public partial class Invoice : BaseEmre
    {
        public Invoice()
        {
            Transactions = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string InvoiceTransactionId { get; set; }
        public string SubscriberNo { get; set; }
        public string Corporation { get; set; }
        public string CorpoCode { get; set; }
        public string CurrencyType { get; set; }
        public string SubscriberName { get; set; }
        public double? InvoiceAmount { get; set; }
        public double? PaymentAmount { get; set; }
        public double? CommissionAmount { get; set; }
        public DateTime? Date { get; set; }
        public string BankRefNo { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceRefNo { get; set; }
        public string InvoiceSeqNo { get; set; }
        public string InvoiceStatus { get; set; }
        public double? CorpCommission { get; set; }
        public double? TotalPayment { get; set; }
        public long TransactionId { get; set; }

        public virtual InvoiceCorporation CorpoCodeNavigation { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}