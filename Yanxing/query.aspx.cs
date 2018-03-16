using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yanxing.DataAccess;
using Yanxing.Models;
using Yanxing.Service;

namespace Yanxing
{
    public partial class query : System.Web.UI.Page
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
            PersonDal pd = new PersonDal();
            Expression<Func<Person, bool>> name = i => i.Pname == TextBox13.Text;
            Expression<Func<Person, bool>> sex = i => i.Psex == DropDownList1.Text;
            Expression<Func<Person, bool>> pro = i => i.Ppro == TextBox15.Text;
            //Expression<Func<Person, bool>> sid = i => i.Ppro == TextBox4.Text;
            Expression<Func<Person, bool>> username = i => i.Username == TextBox17.Text;
            Expression<Func<Person, bool>> exp = i=> i.PID!= null;
            IEnumerable<Person> entity = null; 
            if (TextBox17.Text != "")
            {
                 entity = pd.GetEntities(i => i.Username == TextBox17.Text);
            } else if (DropDownList1.Text != "" || TextBox15.Text != "" || TextBox13.Text != "")
            {
                if(DropDownList1.Text == "" && TextBox15.Text == "" && TextBox13.Text != "")
                {
                    entity = pd.GetEntities(i => i.Pname == TextBox13.Text);
                }else if(DropDownList1.Text != "" && TextBox15.Text == "" && TextBox13.Text == "")
                {
                    entity = pd.GetEntities(i => i.Psex == DropDownList1.Text);
                }else if (DropDownList1.Text == "" && TextBox15.Text != "" && TextBox13.Text == "")
                {
                    entity = pd.GetEntities(i => i.Ppro == TextBox15.Text);
                }else if (DropDownList1.Text != "" && TextBox15.Text != "" && TextBox13.Text == "")
                {
                    entity = pd.GetEntities(i => i.Ppro == TextBox15.Text && i.Psex == DropDownList1.Text);
                }else if (DropDownList1.Text == "" && TextBox15.Text != "" && TextBox13.Text != "")
                {
                    entity = pd.GetEntities(i => i.Ppro == TextBox15.Text && i.Pname == TextBox13.Text);
                }else if (DropDownList1.Text != "" && TextBox15.Text == "" && TextBox13.Text != "")
                {
                    entity = pd.GetEntities(i => i.Psex == DropDownList1.Text && i.Pname == TextBox13.Text);
                }else if(DropDownList1.Text != "" && TextBox15.Text != "" && TextBox13.Text != "")
                {
                    entity = pd.GetEntities(i => i.Psex == DropDownList1.Text && i.Pname == TextBox13.Text && i.Ppro == TextBox15.Text);
                }
                
            }
            else
            {
                entity = null;
            }
            if (entity != null)
            {

                GridView1.DataSource = entity;
                GridView1.DataBind();
                //i => ((Convert(i.PID) != null) AndAlso (i.Psex == value(ASP.query_aspx).DropDownList1.Text))

                Response.Write("<script>alert('查询成功!')</script>");
            }else
            {
                Response.Write("<script>alert('未查到相关信息!')</script>");
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