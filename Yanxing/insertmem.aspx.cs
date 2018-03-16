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
    public partial class insertmem : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            ECService ec = new ECService(Label1.Text);
            Guid Pid = Guid.NewGuid();
            Guid XiaoYanid = Guid.NewGuid();
            XiaoYan x = new XiaoYan();
            Person p = new Person();
            Account a = new Account();
            a.Password = TextBox17.Text;
            a.Username = TextBox17.Text;
            a.UserID = Guid.NewGuid();

            x.isActive = true;
            x.isEC = false;
            x.Sid = ec._ec.Sid;
            x.PID = Pid;
            x.XYID = XiaoYanid;

            p.PID = Pid;
            p.Username = TextBox17.Text;
            p.Pname = TextBox13.Text;
            p.Pgrade = "XiaoYan";
            p.Ppro = TextBox15.Text;
            p.Psex = DropDownList1.Text;
            p.Ptel = TextBox4.Text;
            p.PwechatID = TextBox5.Text;
            p.Pemail = TextBox6.Text;
            p.Pcontact = TextBox7.Text;
            p.Pjob4u = TextBox8.Text;
            p.Ptime = helper.string2long(datel.Value);
            p.Pwork_years = Convert.ToInt16(TextBox16.Text);
            p.Padvs = TextBox9.Text;
            p.Pact4water = TextBox10.Text;
            p.Pact4fire = TextBox11.Text;
            p.Pfield_of_firm = TextBox12.Text;


            //XiaoYanDal xd= new XiaoYanDal();
            //PersonDal pd= new PersonDal();
            //AccountDal ad = new AccountDal();
            //ad.Insert(a);
            //pd.Insert(p);
            //xd.Insert(x);

            try
            {
                ec.insertMem(a, p, x);
                Response.Write("<script>alert('插入成功!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('插入失败!')</script>");
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