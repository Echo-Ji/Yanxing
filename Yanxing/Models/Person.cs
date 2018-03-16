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
    [SQLinqTable("Person")]
    public class Person
    {
        [SQLinqColumn("PID")]//guid做主键
        public Guid PID { get; set; }

        [SQLinqColumn("Ptel")]//edit,not null,check format
        public string Ptel { get; set; }

        [SQLinqColumn("Username")]//学校+学号
        public string Username { get; set; }

        [SQLinqColumn("Pname")]//unedit
        public string Pname { get; set; }
       
        [SQLinqColumn("Ptime")]
        public long Ptime { get; set; }

        [SQLinqColumn("Pgrade")]//not null
        public string Pgrade { get; set; }

        [SQLinqColumn("PwechatID")]//not null
        public string PwechatID { get; set; }

        [SQLinqColumn("Psex")]//null
        public string Psex { get; set; }

        [SQLinqColumn("Pemail")]//null
        public string Pemail { get; set; }

        [SQLinqColumn("Pcontact")]//not null
        public string Pcontact { get; set; }

        [SQLinqColumn("Ppro")]//not null
        public string Ppro { get; set; }

        [SQLinqColumn("Pwork_years")]//not null
        public short Pwork_years { get; set; }

        [SQLinqColumn("Pjob4u")]//null
        public string Pjob4u { get; set; }
        
        [SQLinqColumn("Padvs")]//null
        public string Padvs { get; set; }
        
        [SQLinqColumn("Pact4water")]//null
        public string Pact4water { get; set; }

        [SQLinqColumn("Pact4fire")]//null
        public string Pact4fire { get; set; }

        [SQLinqColumn("Phobbies")]//null
        public string Phobbies { get; set; }

        [SQLinqColumn("Pfield_of_firm")]//not null
        public string Pfield_of_firm { get; set; }
    }
}