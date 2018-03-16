<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="information.aspx.cs" Inherits="Yanxing.information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 578px; top: 257px; position: absolute" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 1003px; top: 155px; position: absolute; height: 87px; width: 228px; bottom: 419px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 92px; position: absolute; height: 63px; width: 249px;" Text="个人信息" Font-Bold="True" Font-Italic="True" Font-Size ="50px "></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 497px; top: 208px; position: absolute; height: 20px" Text="性别"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 629px; top: 594px; position: absolute; height: 52px; width: 97px; right: 645px;" Text="修改" Font-Size="Large" />
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 1056px; top: 592px; position: absolute; height: 52px; width: 95px;" Text="返回" Font-Size="Large" />
        <p>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 138px; top: 228px; position: absolute" Text="姓名"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 578px; top: 313px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 465px; top: 378px; position: absolute; height: 20px" Text="电子邮件"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 578px; top: 374px; position: absolute; right: 587px"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 405px; top: 439px; position: absolute; height: 21px" Text="联系方式（偏好）"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 579px; top: 438px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 369px; top: 501px; position: absolute" Text="从事的（期待的）工作"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: 579px; top: 499px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 898px; top: 170px; position: absolute" Text="优势方面"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 851px; top: 286px; position: absolute" Text="喜欢的静态活动"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server" OnTextChanged="TextBox10_TextChanged" style="z-index: 1; left: 1004px; top: 273px; position: absolute; height: 81px; width: 227px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 846px; top: 398px; position: absolute" Text="喜欢的动态活动"></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server" style="z-index: 1; left: 1005px; top: 385px; position: absolute; height: 75px; width: 228px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" style="z-index: 1; left: 877px; top: 503px; position: absolute" Text="公司领域"></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server" style="z-index: 1; left: 1007px; top: 486px; position: absolute; height: 49px; width: 227px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label13" runat="server" style="z-index: 1; left: 135px; top: 290px; position: absolute; height: 26px; width: 136px" Text="加入雁行时间"></asp:Label>
        <asp:Label ID="Label14" runat="server" style="z-index: 1; left: 138px; top: 354px; position: absolute" Text="成员等级"></asp:Label>
        <asp:Label ID="Label15" runat="server" style="z-index: 1; left: 142px; top: 418px; position: absolute; height: 30px;" Text="专业"></asp:Label>
        <asp:Label ID="Label16" runat="server" style="z-index: 1; left: 139px; top: 473px; position: absolute; height: 21px" Text="工作时间"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 580px; top: 205px; position: absolute; height: 24px; width: 76px; right: 697px">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
            <asp:ListItem>保密</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 459px; top: 258px; position: absolute" Text="电话号码"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 481px; top: 318px; position: absolute" Text="微信号"></asp:Label>
    </form>
</body>
</html>
