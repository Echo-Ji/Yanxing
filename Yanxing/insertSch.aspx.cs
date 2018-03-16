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
    public partial class insertSch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            BoardMemberService bms = new BoardMemberService();
            if (bms.CreateSchool(new Models.School() { Sname = TextBox1.Text, Sloc = TextBox2.Text }))
            {

                var entity = new SchoolDal().GetEntities(i=> i.Sid>0);
                entity = entity.OrderBy(l => l.Sid);
                GridView1.DataSource = entity;
                Response.Write("<script>alert('新建学校成功！')</script>");
                GridView1.DataBind();
                
            }
            else
            {
                Response.Write("<script>alert('新建学校失败！')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");
        }
    }
}