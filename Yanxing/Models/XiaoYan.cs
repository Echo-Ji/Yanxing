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
    [SQLinqTable("XiaoYan")]
    public class XiaoYan
    {
        [SQLinqColumn("XYID")]
        public Guid XYID { get; set; }

        [SQLinqColumn("PID")]
        public Guid PID { get; set; }

        [SQLinqColumn("Sid")]
        public int Sid { get; set; }

        [SQLinqColumn("isEC")]
        public bool isEC { get; set; }

        [SQLinqColumn("isActive")]
        public bool isActive { get; set; }
    }
}