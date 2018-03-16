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
    [SQLinqTable("BoardMember")]
    public class BoardMember
    {
        [SQLinqColumn("BMID")]
        public Guid BMID { get; set; }

        [SQLinqColumn("PID")]
        public Guid PID { get; set; }

        [SQLinqColumn("isActive")]
        public bool isActive { get;set;}
    }
}