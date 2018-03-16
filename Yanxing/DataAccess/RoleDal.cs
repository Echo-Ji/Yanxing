using DapperDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class RoleDal : BaseDal<Role>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into Role VALUES(@Rname, @Rscore)";
            sqlCUD.Update = "update Role set Rscore = @Rscore where Rname = @Rname";
            sqlCUD.Delete = "delete from Role where Rname =@Rname";
        }
    }
}