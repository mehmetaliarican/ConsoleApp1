using System;
using System.Collections.Generic;
using PureHBS.Base;

namespace Models
{
    public partial class StudentLecturer :BaseEntity
    {
        public int StudentId {get;set;}
        public Student Student {get;set;}
        public int LecturerId {get;set;}
        public Lecturer Lecturer {get;set;}
    }
}

