using System;
using System.Collections.Generic;
using PureHBS.Base;

namespace Models
{
    public partial class sysdiagrams :BaseEntity
    {
        public string name { get; set; }
        public int principal_id { get; set; }
        public int diagram_id { get; set; }
        public int version { get; set; }
        public Byte[] definition { get; set; }
    }
}

