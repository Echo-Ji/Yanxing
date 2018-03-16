using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yanxing.Models;
using Yanxing.DataAccess;
using Yanxing.Service;

namespace Yanxing
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Name
        {
            get
            {
                return TextBox1.Text;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            LoginService ls = new LoginService();
            int resultlogin;
            resultlogin = ls.login(TextBox1.Text, TextBox2.Text);
            if (resultlogin == 0)
            {
                Response.Write("<script>alert('不存在该用户!')</script>");
            }else if (resultlogin == 1)
            {
                Response.Write("<script>alert('密码正确!')</script>");
                Session["key"] = TextBox1.Text;
                Server.Transfer("user.aspx");
            }
            else
            {
                Response.Write("<script>alert('密码错误!')</script>");
            }

        }
    }
}