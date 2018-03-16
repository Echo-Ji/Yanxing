using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQLinq;

namespace Yanxing.Models
{
    [SQLinqTable("Participant")]
    public class Participant
    {
        [SQLinqColumn("PTid")]
        public int PTid { get; set; }

        [SQLinqColumn("Aid")]
        public int Aid { get; set; }

        [SQLinqColumn("PID")]
        public Guid PID { get; set; }

        [SQLinqColumn("PTtime")]
        public long PTtime { get; set; }

        [SQLinqColumn("Rid")]
        public int Rid { get; set; }
    }
}