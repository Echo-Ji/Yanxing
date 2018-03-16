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
    public partial class PointGen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{

            //    Label1.Text = Session["key"].ToString();

            //}
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            BoardMemberService bms = new BoardMemberService();
            //string st = STYY.Text + "-" + STMM.Text + "-" + STDD.Text + " 0:00:00";
            //string et = ETYY.Text + "-" + ETMM.Text + "-" + ETDD.Text + " 0:00:00";
            //Response.Write("<script>('"+st+"\t"+et+"')</script>");
            var points = bms.GenPointsByGivenTime(DateTime.Parse(datel.Value), DateTime.Parse(datel2.Value));
            if (points == null)
            {
                Response.Write("<script>('无符合条件查询')</script>");
                return;
            }
            GridView1.DataSource = points;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");
        }
    }
}