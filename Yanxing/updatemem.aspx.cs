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
    public partial class updatemem : System.Web.UI.Page
    {
        private XiaoYanService xiaoyan;

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();


            xiaoyan = new XiaoYanService(TextBox17.Text);
            if(xiaoyan._xiaoyan == null)
            {
                Response.Write("<script>alert('未找到该用户!')</script>");
            }else
            {
                TextBox13.Text = xiaoyan._person.Pname;
                TextBox15.Text = xiaoyan._person.Ppro;
                DropDownList1.Text = xiaoyan._person.Psex;
                TextBox4.Text = xiaoyan._person.Ptel;
                TextBox5.Text = xiaoyan._person.PwechatID;
                TextBox6.Text = xiaoyan._person.Pemail;
                TextBox7.Text = xiaoyan._person.Pcontact;
                TextBox8.Text = xiaoyan._person.Pjob4u;
                datel.Value = helper.long2string(xiaoyan._person.Ptime);
                TextBox16.Text = Convert.ToString(xiaoyan._person.Pwork_years);
                TextBox9.Text = xiaoyan._person.Padvs;
                TextBox10.Text = xiaoyan._person.Pact4water;
                TextBox11.Text = xiaoyan._person.Pact4fire;
                TextBox12.Text = xiaoyan._person.Pfield_of_firm;
                Response.Write("<script>alert('查找成功!')</script>");
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            ECService ec = new ECService(Label1.Text);

            xiaoyan = new XiaoYanService(TextBox17.Text);

            xiaoyan._xiaoyan.isActive = true;
            xiaoyan._xiaoyan.isEC = false;
            xiaoyan._xiaoyan.Sid = ec._ec.Sid;

            xiaoyan._person.Username = TextBox17.Text;
            xiaoyan._person.Pname = TextBox13.Text;
            xiaoyan._person.Pgrade = "XiaoYan";
            xiaoyan._person.Ppro = TextBox15.Text;
            xiaoyan._person.Psex = DropDownList1.Text;
            xiaoyan._person.Ptel = TextBox4.Text;
            xiaoyan._person.PwechatID = TextBox5.Text;
            xiaoyan._person.Pemail = TextBox6.Text;
            xiaoyan._person.Pcontact = TextBox7.Text;
            xiaoyan._person.Pjob4u = TextBox8.Text;
            xiaoyan._person.Ptime = helper.string2long(datel.Value);
            xiaoyan._person.Pwork_years = Convert.ToInt16(TextBox16.Text);
            xiaoyan._person.Padvs = TextBox9.Text;
            xiaoyan._person.Pact4water = TextBox10.Text;
            xiaoyan._person.Pact4fire = TextBox11.Text;
            xiaoyan._person.Pfield_of_firm = TextBox12.Text;


            //XiaoYanDal xd= new XiaoYanDal();
            //PersonDal pd= new PersonDal();
            //AccountDal ad = new AccountDal();
            //ad.Insert(a);
            //pd.Insert(p);
            //xd.Insert(x);


            try
            {
                ec.updateMem(xiaoyan._person, xiaoyan._xiaoyan);
                Response.Write("<script>alert('更新成功!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('更新失败!')</script>");
            }
        }
    }
}