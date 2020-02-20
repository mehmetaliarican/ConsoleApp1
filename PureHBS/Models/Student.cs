using System;
using System.Collections.Generic;
using PureHBS.Base;

namespace Models
{
    public partial class Student :BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
    }
}

