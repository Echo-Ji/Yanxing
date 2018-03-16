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
    public partial class information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Helper helper = new Helper();
                Label1.Text = Session["key"].ToString();
                XiaoYanService x = new XiaoYanService(Label1.Text);
                TextBox4.Text = x._person.Ptel;
                TextBox5.Text = x._person.PwechatID;
                TextBox6.Text = x._person.Pemail;
                TextBox7.Text = x._person.Pcontact;
                TextBox8.Text = x._person.Pjob4u;
                TextBox9.Text = x._person.Padvs;
                TextBox10.Text = x._person.Pact4water;
                TextBox11.Text = x._person.Pact4fire;
                TextBox12.Text = x._person.Pfield_of_firm;
                Label4.Text = "姓名:" + x._person.Pname;
                Label13.Text = "加入雁行时间："+ helper.long2string(x._person.Ptime);
                Label14.Text = "等级:" + x._person.Pgrade;
                Label15.Text = "专业："+x._person.Ppro;
                Label16.Text = "工作年长："+ x._person.Pwork_years.ToString();
                DropDownList1.Text = x._person.Psex;


            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XiaoYanService x = new XiaoYanService(Label1.Text);
            x._person.Psex = DropDownList1.Text;
            x._person.Ptel = TextBox4.Text;
            x._person.PwechatID = TextBox5.Text;
            x._person.Pemail = TextBox6.Text;
            x._person.Pcontact = TextBox7.Text;
            x._person.Pjob4u = TextBox8.Text;
            x._person.Padvs = TextBox9.Text;
            x._person.Pact4water = TextBox10.Text;
            x._person.Pact4fire = TextBox11.Text;
            x._person.Pfield_of_firm = TextBox12.Text;
            
            try {
                x.updateInfo(x._person, x._xiaoyan);
                Response.Write("<script>alert('修改成功!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('修改失败!')</script>");
            }
            
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

    }
}