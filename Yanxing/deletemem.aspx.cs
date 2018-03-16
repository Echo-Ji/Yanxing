using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yanxing.DataAccess;
using Yanxing.Models;
using Yanxing.Service;

namespace Yanxing
{
    public partial class deletemem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["key"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ECService ec = new ECService(Label1.Text);
            PersonDal pd = new PersonDal();
            var pers = pd.GetEntities(m => m.Username == TextBox1.Text);
            Person ps = null;
            foreach (var per in pers)
            {
                ps = per;
            }
            if (ps != null)
            {
                ec.deleteMem(ps.PID);
                Response.Write("<script>alert('删除成功!')</script>");
            }else
            {
                Response.Write("<script>alert('未找到该用户!')</script>");
            }
            

        }
    }
}