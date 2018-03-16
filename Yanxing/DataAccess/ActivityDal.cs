using DapperDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class ActivityDal : BaseDal<Activity>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into Activity VALUES(@Aname, @Atime,@Aloc,@Arate)";
            sqlCUD.Update = "update Activity set Arate = @Arate where Aname = @Aname and Atime=@Atime and Aloc=@Aloc";
            sqlCUD.Delete = "delete from Activity where Aname = @Aname and Atime=@Atime and Aloc=@Aloc";
        }
    }
}