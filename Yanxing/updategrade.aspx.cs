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
    public partial class updategrade : System.Web.UI.Page
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



        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            ECleaderService ec = new ECleaderService();
            XiaoYanService xy = new XiaoYanService(TextBox4.Text);
            string grade = TextBox5.Text;
            try
            {
                ec.updateMemGrade(xy._person, grade);

                Response.Write("<script>alert('更新成功!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('更新失败!')</script>");
            }
        }
    }
}