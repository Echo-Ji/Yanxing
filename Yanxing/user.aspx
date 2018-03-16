<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="Yanxing.user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 83px; top: 139px; position: absolute" Text="Label" Font-Bold="True" Font-Italic="True" Font-Size="50px"></asp:Label>
        <asp:Button ID="Button5" runat="server" Font-Size="Large" OnClick="Button5_Click" style="z-index: 1; left: 370px; top: 97px; position: absolute" Text="登出" />
        <asp:Button ID="Button9" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button9_Click" style="z-index: 1; left: 371px; top: 335px; position: absolute; height: 50px; width: 192px" Text="修改学校信息" />
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 77px; top: 73px; position: absolute; bottom: 379px; width: 241px;" Text="欢迎您！" Font-Bold="True" Font-Italic="True" Font-Size="50px" ForeColor="Black" ></asp:Label>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 62px; top: 245px; position: absolute; height: 52px; width: 188px;" Text="个人信息修改" BorderStyle="Double" BackColor="#99CCFF" Font-Size="Large" />
        <asp:Button ID="Button4" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button4_Click" style="z-index: 1; left: 64px; top: 335px; position: absolute; height: 50px; width: 186px" Text="增加成员" />
        <asp:Button ID="Button6" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button6_Click" style="z-index: 1; left: 66px; top: 427px; position: absolute; height: 50px; width: 185px; right: 1105px" Text="更新成员信息" />
        <asp:Button ID="Button7" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button7_Click" style="z-index: 1; left: 66px; top: 519px; position: absolute; height: 49px; width: 185px" Text="删除成员" />
        <asp:Button ID="Button8" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button8_Click" style="z-index: 1; left: 374px; top: 244px; position: absolute; height: 51px; width: 191px" Text="他人信息查询" />
        <asp:Button ID="Button10" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button10_Click" style="z-index: 1; left: 374px; top: 428px; position: absolute; height: 51px; width: 192px" Text="插入活动记录" />
        <asp:Button ID="Button11" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button11_Click" style="z-index: 1; left: 376px; top: 518px; position: absolute; height: 49px; width: 190px" Text="更新活动记录" />
        <asp:Button ID="Button12" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button12_Click" style="z-index: 1; left: 64px; top: 339px; position: absolute; height: 44px; width: 184px" Text="更改他人等级" />
        <asp:Button ID="Button13" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button13_Click" style="z-index: 1; left: 374px; top: 335px; position: absolute; height: 50px; width: 189px; bottom: 214px;" Text="插入角色" />
        <asp:Button ID="Button14" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button14_Click" style="z-index: 1; left: 70px; top: 430px; position: absolute; height: 45px; width: 176px" Text="插入活动" />
        <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" style="z-index: 1; left: 67px; top: 339px; position: absolute; height: 42px; width: 181px" Text="查询分数" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" />

        <asp:Button ID="Button16" runat="server" BackColor="#99CCFF" BorderStyle="Double" Font-Size="Large" OnClick="Button16_Click" style="z-index: 1; left: 374px; top: 337px; position: absolute; height: 45px; width: 186px" Text="新建学校" />

    </form>
</body>
</html>
