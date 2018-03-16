using DapperDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class AccountDal : BaseDal<Account>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into Account VALUES(@UserID,@Username, @Password)";
            sqlCUD.Update = "update Account set Password = @Password,Username = @Username where UserID=@UserID";
            sqlCUD.Delete = "delete from Account where UserID=@UserID";
        }
    }
}