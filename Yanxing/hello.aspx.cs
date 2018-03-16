using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yanxing.DataAccess;
using System.Windows;
using Yanxing.Models;

namespace Yanxing
{
    public partial class hello : System.Web.UI.Page
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
            AccountDal login = new AccountDal();
            var entity = login.GetEntities(i => i.Username == TextBox1.Text);
            if (entity.Count<Account>() == 0)
            {
                Response.Write("<script>alert('不存在该用户!')</script>");
            }
            foreach (var p in entity)
            {
                if (p.Password.Equals(TextBox2.Text))
                {
                    //Response.Write("<script>alert('密码正确!')</script>");
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
}