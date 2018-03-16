using SQLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yanxing.Models
{
    [SQLinqTable("School")]
    public class School
    {
        [SQLinqColumn("Sid")]
        public int Sid { get; set; }

        [SQLinqColumn("Sname")]//pk
        public string Sname { get; set; }

        [SQLinqColumn("Sloc")]
        public string Sloc { get; set;}
    }
}