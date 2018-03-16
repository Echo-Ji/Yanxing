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
    [SQLinqTable("Points")]
    public class PointsView
    {
        [SQLinqColumn("tel")]
        public string tel { get; set; }

        [SQLinqColumn("username")]
        public string username { get; set; }

        [SQLinqColumn("name")]
        public string name { get; set; }

        [SQLinqColumn("grade")]
        public string grade { get; set; }

        [SQLinqColumn("pro")]
        public string pro { get; set; }

        [SQLinqColumn("firm")]
        public string firm { get; set; }

        [SQLinqColumn("point")]
        public int point { get; set; }

        [SQLinqColumn("time")]
        public long time { get; set; }
    }
}