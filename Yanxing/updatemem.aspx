<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updatemem.aspx.cs" Inherits="Yanxing.updatemem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script type =" text/javascript" src =" My97DatePicker/WdatePicker.js" ></script>
    <style type="text/css">
        #datel {
            z-index: 1;
            left: 230px;
            top: 445px;
            position: absolute;
        }
    </style>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 636px; top: 304px; position: absolute" Text="微信号"></asp:Label>
    
    </div>
        <input runat="server" type =" text" class =" Wdate" onfocus="WdatePicker({lang:'zh-cn'})" id="datel" />
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 720px; top: 232px; position: absolute" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 1131px; top: 153px; position: absolute; height: 87px; width: 228px; bottom: 514px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 92px; position: absolute; height: 63px; width: 313px; right: 926px;" Text="更新成员信息" Font-Bold="True" Font-Italic="True" Font-Size ="50px"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 655px; top: 173px; position: absolute; height: 20px; right: 624px;" Text="性别"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 613px; top: 240px; position: absolute" Text="电话号码"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 552px; top: 586px; position: absolute; height: 52px; width: 97px; right: 707px;" Text="查询" Font-Size="Large" />
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 1115px; top: 586px; position: absolute; height: 52px; width: 95px;" Text="返回" Font-Size="Large" />
        <p>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 164px; top: 271px; position: absolute" Text="姓名"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 719px; top: 300px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 617px; top: 370px; position: absolute; height: 20px" Text="电子邮件"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 719px; top: 369px; position: absolute; right: 571px"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 544px; top: 434px; position: absolute; height: 22px" Text="联系方式（偏好）"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 717px; top: 433px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 498px; top: 498px; position: absolute; height: 20px;" Text="从事的（期待的）工作"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: 716px; top: 497px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 1035px; top: 161px; position: absolute" Text="优势方面"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 972px; top: 272px; position: absolute" Text="喜欢的静态活动"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server" OnTextChanged="TextBox10_TextChanged" style="z-index: 1; left: 1131px; top: 265px; position: absolute; height: 81px; width: 227px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 966px; top: 381px; position: absolute" Text="喜欢的动态活动"></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server" style="z-index: 1; left: 1128px; top: 373px; position: absolute; height: 75px; width: 228px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 1019px; top: 480px; position: absolute" Text="公司领域"></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server" style="z-index: 1; left: 1126px; top: 475px; position: absolute; height: 49px; width: 227px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 84px; top: 447px; position: absolute; height: 26px; width: 136px" Text="加入雁行时间"></asp:Label>
        <asp:Label ID="Label15" runat="server" style="z-index: 1; left: 162px; top: 326px; position: absolute; height: 22px; " Text="专业"></asp:Label>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 124px; top: 383px; position: absolute; height: 21px; bottom: 152px;" Text="工作时间"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 721px; top: 171px; position: absolute; height: 24px; width: 76px; right: 681px">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
            <asp:ListItem>保密</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox13" runat="server" style="z-index: 1; left: 229px; top: 269px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox15" runat="server" style="z-index: 1; left: 229px; top: 324px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox16" runat="server" style="z-index: 1; left: 230px; top: 382px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox17" runat="server" style="z-index: 1; left: 232px; top: 174px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 65px; top: 181px; position: absolute" Text="用户名（查询项）"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 111px; top: 210px; position: absolute" Text="[学校简写+学号，如：bh15061088]"></asp:Label>
        <asp:Button ID="Button3" runat="server" Font-Size="Large" OnClick="Button3_Click" style="z-index: 1; left: 806px; top: 588px; position: absolute; height: 50px; width: 110px" Text="修改" />
    </form>
</body>
</html>
