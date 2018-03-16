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
    public partial class insertrole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Label1.Text = Session["key"].ToString();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            ECleaderService el = new ECleaderService();
            Role r = new Role();
            r.Rname = TextBox7.Text;
            r.Rscore = Convert.ToInt16(TextBox6.Text);
            try
            {
                el.CreateRole(r);
                Response.Write("<script>alert('插入成功!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('插入失败!')</script>");
            }
        }
    }
}