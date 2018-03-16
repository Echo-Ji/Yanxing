using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQLinq;

namespace Yanxing.Models
{
    [SQLinqTable("Role")]
    public class Role
    {
        [SQLinqColumn("Rid")]
        public int Rid { get; set; }

        [SQLinqColumn("Rname")]
        public string Rname { get; set; }

        [SQLinqColumn("Rscore")]
        public int Rscore { get; set; }
    }
}