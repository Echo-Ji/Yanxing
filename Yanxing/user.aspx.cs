using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Yanxing.DataAccess;
using Yanxing.Models;
using Yanxing.Service;

namespace Yanxing
{
    public partial class user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = Session["key"].ToString();
                XiaoYanService x = new XiaoYanService(Label1.Text);
                if(x._person.Pgrade == "EC")
                {
                    Button3.Visible = true;  //个人信息修改
                    Button4.Visible = true;  //增加成员
                    Button6.Visible = true;  //修改成员
                    Button7.Visible = true; //删除成员
                    Button8.Visible = true;  //查询功能
                    Button9.Visible = true;  //修改学校信息
                    Button10.Visible = true;  //插入活动记录
                    Button11.Visible = true;  //修改活动记录
                    Button12.Visible = false; //更改他人等级
                    Button13.Visible = false;
                    Button14.Visible = false;
                    Button15.Visible = false;
                    Button16.Visible = false;
                }
                else if (x._person.Pgrade == "ECleader")
                {
                    Button3.Visible = true;  //个人信息修改
                    Button4.Visible = false;  //增加成员
                    Button6.Visible = false;  //修改成员
                    Button7.Visible = false; //删除成员
                    Button8.Visible = true;  //查询功能
                    Button9.Visible = false;  //修改学校信息
                    Button10.Visible = false;  //插入活动记录
                    Button11.Visible = false;  //修改活动记录
                    Button12.Visible = true;  //修改等级
                    Button13.Visible = true;  //插入角色
                    Button14.Visible = true; //插入活动
                    Button15.Visible = false;
                    Button16.Visible = false;
                }
                else if(x._person.Pgrade == "XiaoYan"||x._person.Pgrade == "DaYan")
                {
                    Button3.Visible = true;
                    Button4.Visible = false;
                    Button6.Visible = false;
                    Button7.Visible = false;
                    Button8.Visible = true;
                    Button9.Visible = false;
                    Button10.Visible = false;
                    Button11.Visible = false;
                    Button12.Visible = false;
                    Button13.Visible = false;
                    Button14.Visible = false;
                    Button15.Visible = false;
                    Button16.Visible = false;
                }
                else if (x._person.Pgrade == "BoardMember")
                {
                    Button3.Visible = true;  //个人信息修改
                    Button4.Visible = false;  //增加成员
                    Button6.Visible = false;  //修改成员
                    Button7.Visible = false; //删除成员
                    Button8.Visible = true;  //查询功能
                    Button9.Visible = false;  //修改学校信息
                    Button10.Visible = false;  //插入活动记录
                    Button11.Visible = false;  //修改活动记录
                    Button12.Visible = false;  //修改等级
                    Button13.Visible = false;  //插入角色
                    Button14.Visible = false; //插入活动
                    Button15.Visible = true;  //查询分数
                    Button16.Visible = true; //插入学校
                }
            }
                
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("information.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertmem.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("updatemem.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("deletemem.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("query.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("updateschool.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertparticipant.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("updateparticipant.aspx");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("updategrade.aspx");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertrole.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertactivity.aspx");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("PointGen.aspx");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertSch.aspx");
        }


        //public static DataTable ToDataTable<T>(IEnumerable<T> collection)
        //{
        //    var props = typeof(T).GetProperties();
        //    var dt = new DataTable();
        //    dt.Columns.AddRange(props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());
        //    if (collection.Count() > 0)
        //    {
        //        for (int i = 0; i < collection.Count(); i++)
        //        {
        //            ArrayList tempList = new ArrayList();
        //            foreach (PropertyInfo pi in props)
        //            {
        //                object obj = pi.GetValue(collection.ElementAt(i), null);
        //                tempList.Add(obj);
        //            }
        //            object[] array = tempList.ToArray();
        //            dt.LoadDataRow(array, true);
        //        }
        //    }
        //    return dt;
        //}


    }
}