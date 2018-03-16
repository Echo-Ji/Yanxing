<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="query.aspx.cs" Inherits="Yanxing.query" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 1124px; top: 174px; position: absolute" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 92px; position: absolute; height: 63px; width: 249px; right: 987px;" Text="查询成员" Font-Bold="True" Font-Italic="True" Font-Size ="50px"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 501px; top: 174px; position: absolute; height: 20px; right: 798px;" Text="性别"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 1053px; top: 177px; position: absolute; height: 20px;" Text="学校id"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 538px; top: 223px; position: absolute; height: 52px; width: 97px; right: 753px;" Text="查询" Font-Size="Large" />
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 812px; top: 228px; position: absolute; height: 52px; width: 95px;" Text="返回" Font-Size="Large" />
        <p>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 151px; top: 173px; position: absolute" Text="姓名"></asp:Label>
        </p>
        <asp:Label ID="Label15" runat="server" style="z-index: 1; left: 736px; top: 174px; position: absolute; height: 22px;" Text="专业"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 552px; top: 174px; position: absolute; height: 24px; width: 76px; right: 760px">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
            <asp:ListItem>保密</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox13" runat="server" style="z-index: 1; left: 229px; top: 172px; position: absolute; right: 971px;"></asp:TextBox>
        <asp:TextBox ID="TextBox15" runat="server" style="z-index: 1; left: 785px; top: 173px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox17" runat="server" style="z-index: 1; left: 229px; top: 216px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label17" runat="server" style="z-index: 1; left: 132px; top: 218px; position: absolute" Text="用户名"></asp:Label>
        <asp:Label ID="Label18" runat="server" style="z-index: 1; left: 111px; top: 250px; position: absolute" Text="[学校简写+学号，如：bh15061088]"></asp:Label>
        <asp:GridView ID="GridView1" runat="server"  style="z-index: 1; left: 199px; top: 337px; position: absolute; height: 139px; width: 241px; right: 932px;" CellPadding="3" GridLines="None" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellSpacing="1">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
    </form>
</body>
</html>

