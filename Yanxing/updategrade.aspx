<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updategrade.aspx.cs" Inherits="Yanxing.updategrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 573px; top: 296px; position: absolute" Text="等级"></asp:Label>
    
    </div>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 653px; top: 221px; position: absolute" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 92px; position: absolute; height: 63px; width: 313px; right: 926px;" Text="更新等级" Font-Bold="True" Font-Italic="True" Font-Size ="50px"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 557px; top: 224px; position: absolute" Text="用户名"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 1072px; top: 478px; position: absolute; height: 52px; width: 95px;" Text="返回" Font-Size="Large" />
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 652px; top: 294px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Font-Size="Large" OnClick="Button3_Click" style="z-index: 1; left: 689px; top: 470px; position: absolute; height: 50px; width: 110px" Text="修改" />
    </form>
</body>
</html>


