using DapperDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class YanFriendsDal : BaseDal<YanFriends>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into DaYan VALUES(@YFID,@PID,@WTBMentor4NJ,@isActive)";
            sqlCUD.Update = "update DaYan setWTBMentor4NJ=@WTBMentor4NJ,isActive=@isActive where YFID = @YFID";
            sqlCUD.Delete = "delete from DaYan where YFID = @YFID";
            //throw new NotImplementedException();
        }
    }
}