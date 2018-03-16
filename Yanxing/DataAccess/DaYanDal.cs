using DapperDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class DaYanDal : BaseDal<DaYan>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into DaYan VALUES(@DYID,@PID,@Sid,@isECleader,@isActive)";
            sqlCUD.Update = "update DaYan set isECleader=@isECleader,isActive=@isActive where DYID = @DYID";
            sqlCUD.Delete = "delete from DaYan where DYID = @DYID";
        }
    }
}