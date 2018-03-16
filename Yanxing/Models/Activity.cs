using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQLinq;

namespace Yanxing.Models
{
    [SQLinqTable("Activity")]
    public class Activity
    {
        [SQLinqColumn("Aid")]
        public int Aid { get; set; }

        [SQLinqColumn("Aname")]
        public string Aname { get; set; }

        [SQLinqColumn("Atime")]
        public long Atime { get; set; }

        [SQLinqColumn("Aloc")]
        public string Aloc { get; set; }

        [SQLinqColumn("Arate")]
        public int Arate { get; set; }
    }
}