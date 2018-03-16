using DapperDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class BoardMemberDal : BaseDal<BoardMember>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into BoardMember VALUES(@BMID,@PID,@isActive)";
            sqlCUD.Update = "update BoardMember set isActive=@isActive where BMID = @BMID";
            sqlCUD.Delete = "delete from BoardMember where BMID = @BMID";
        }
    }
}