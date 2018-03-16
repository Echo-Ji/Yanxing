using SQLinq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Yanxing.Models
{
    [SQLinqTable("DaYan")]
    public class DaYan
    {
        [SQLinqColumn("DYID")]
        public Guid DYID { get; set; }

        [SQLinqColumn("PID")]
        public Guid PID { get; set; }

        [SQLinqColumn("Sid")]
        public int Sid { get; set; }

        [SQLinqColumn("isECleader")]
        public bool isECleader { get; set; }

        [SQLinqColumn("isActive")]
        public bool isActive { get; set; }
    }
}