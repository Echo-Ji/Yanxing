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
    [SQLinqTable("YanFriends")]
    public class YanFriends
    {
        [SQLinqColumn("YFID")]
        public Guid YFID { get; set; }

        [SQLinqColumn("PID")]
        public Guid PID { get; set; }

        [SQLinqColumn("WTBMentor4NJ")]//editable
        public bool WTBMentor4NJ { get; set; }

        [SQLinqColumn("isActive")]
        public bool isActive { get; set; }
    }
}