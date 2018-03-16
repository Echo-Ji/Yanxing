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
    public partial class insertparticipant : System.Web.UI.Page
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
            ECService ec = new ECService(Label1.Text);
            Participant pt = new Participant();
            XiaoYanService xy = new XiaoYanService(TextBox5.Text);
            pt.Aid = Convert.ToInt32(TextBox4.Text);
            pt.Rid = Convert.ToInt32(TextBox6.Text);
            pt.PID = xy._person.PID;
            pt.PTtime = helper.string2long(datel.Value);
            try
            {
                ec.insertParticipant(pt);
                Response.Write("<script>alert('插入成功!')</script>");
            }catch(Exception ex)
            {
                Response.Write("<script>alert('插入失败!')</script>");
            }
        }
    }
}