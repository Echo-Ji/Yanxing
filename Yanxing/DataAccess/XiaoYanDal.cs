using DapperDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class XiaoYanDal : BaseDal<XiaoYan>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into XiaoYan VALUES(@XYID,@PID,@Sid,@isEC,@isActive)";
            sqlCUD.Update = "update XiaoYan set isEC=@isEC,isActive=@isActive where XYID = @XYID";
            sqlCUD.Delete = "delete from XiaoYan where XYID = @XYID";
        }
    }
}