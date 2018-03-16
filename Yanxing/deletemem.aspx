<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deletemem.aspx.cs" Inherits="Yanxing.deletemem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 92px; position: absolute; height: 63px; width: 249px; right: 987px;" Text="删除成员" Font-Bold="True" Font-Italic="True" Font-Size ="50px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" style="z-index: 1; left: 620px; top: 522px; position: absolute; height: 38px; width: 102px" Text="删除" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 580px; top: 364px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 479px; top: 369px; position: absolute; height: 20px" Text="用户名"></asp:Label>
        <asp:Button ID="Button2" runat="server" Font-Size="Large" OnClick="Button2_Click" style="z-index: 1; left: 984px; top: 524px; position: absolute; height: 37px; width: 112px" Text="返回" />
    </form>
</body>
</html>

