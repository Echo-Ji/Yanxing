using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yanxing.DataAccess;
using Yanxing.Models;

namespace Yanxing.Service
{
    public class LoginService
    {
        public int login(string username,string password)
        {
            AccountDal login = new AccountDal();
            var entity = login.GetEntities(i => i.Username == username);
            if (entity.Count<Account>() == 0)
            {
                //Response.Write("<script>alert('不存在该用户!')</script>");
                return 0;
            }
            foreach (var p in entity)
            {
                if (p.Password.Equals(password))
                {
                    //Response.Write("<script>alert('密码正确!')</script>");
                    //Session["key"] = TextBox1.Text;
                    //Server.Transfer("user.aspx");
                    return 1;

                }
                else
                {
                    //Response.Write("<script>alert('密码错误!')</script>");
                    return 2;
                }
            }
            return 0;
        }
    }
}