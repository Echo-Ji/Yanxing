<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertrole.aspx.cs" Inherits="Yanxing.insertrole" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 92px; position: absolute; height: 63px; width: 313px; right: 926px;" Text="插入角色" Font-Bold="True" Font-Italic="True" Font-Size ="50px"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 551px; top: 224px; position: absolute" Text="角色名字"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 1072px; top: 478px; position: absolute; height: 52px; width: 95px;" Text="返回" Font-Size="Large" />
        <p>
            &nbsp;</p>
        <asp:Button ID="Button3" runat="server" Font-Size="Large" OnClick="Button3_Click" style="z-index: 1; left: 682px; top: 478px; position: absolute; height: 50px; width: 110px; right: 568px;" Text="插入" />
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 654px; top: 295px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label22" runat="server" style="z-index: 1; left: 550px; top: 299px; position: absolute; height: 20px;" Text="角色分数"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 654px; top: 225px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>

