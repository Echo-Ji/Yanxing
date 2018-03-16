using DapperDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.Models;

namespace Yanxing.DataAccess
{
    public class PersonDal : BaseDal<Person>
    {
        public override void SetSqlCUD()
        {
            sqlCUD.Add = "insert into Person VALUES(@PID,@Ptel,@Username,@Pname,@Ptime,@Pgrade,@PwechatID,@Psex,@Pemail,@Pcontact,@Ppro,@Pwork_years,@Pjob4u,@Padvs,@Pact4water,@Pact4fire,@Phobbies,@Pfield_of_firm)";
            sqlCUD.Update = "update Person set Ptel=@Ptel,Pgrade=@Pgrade,PwechatID=@PwechatID,Psex=@Psex,Pemail=@Pemail,Pcontact=@Pcontact,Pjob4u=@Pjob4u,Padvs=@Padvs,Pact4water=@Pact4water,Pact4fire=@Pact4fire,Phobbies=@Phobbies,Pfield_of_firm=@Pfield_of_firm where PID=@PID";
            sqlCUD.Delete = "delete from Person where PID = @PID";
        }
    }
}