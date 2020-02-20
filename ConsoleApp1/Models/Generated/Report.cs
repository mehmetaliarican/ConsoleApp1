﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using EmreNameSpace;

namespace ConsoleApp1.Models.Generated
{
    public partial class Report : BaseEmre
    {
        public long Id { get; set; }
        public bool Active { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public long? CreatorId { get; set; }
        public long? UpdateId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public bool IsFinished { get; set; }

        public virtual Person Creator { get; set; }
        public virtual Person Update { get; set; }
    }
}