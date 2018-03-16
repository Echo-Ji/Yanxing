using DapperDal;
using SQLinq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class SchoolDal : BaseDal<School>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into School VALUES(@Sname,@Sloc)";
            sqlCUD.Update = "update School set Sname = @Sname ,Sloc = @Sloc where Sid=@Sid";
            sqlCUD.Delete = "delete from School where Sname=@Sname";

        }
    }
}