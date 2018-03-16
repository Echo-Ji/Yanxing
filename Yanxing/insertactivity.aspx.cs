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
    public partial class insertactivity : System.Web.UI.Page
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
            Activity ac = new Activity();
            ac.Aloc = TextBox7.Text;
            ac.Aname = TextBox9.Text;
            ac.Atime = helper.string2long(datel.Value);
            ac.Arate = Convert.ToInt32(TextBox8.Text);
            try
            {
                el.CreateActivity(ac);
                Response.Write("<script>alert('插入成功!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('插入失败!')</script>");
            }
        }
    }
}