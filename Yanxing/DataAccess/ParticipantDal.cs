using DapperDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class ParticipantDal : BaseDal<Participant>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into Participant VALUES(@Aid, @PID, @PTtime, @Rid)";
            sqlCUD.Update = "update Participant set PTtime = @PTtime,Rid = @Rid where Aid = @Aid and PID = @PID";
            sqlCUD.Delete = "delete from Participant where Aid = @Aid and PID = @PID";
        }
    }
}