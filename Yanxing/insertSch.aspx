<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertSch.aspx.cs" Inherits="Yanxing.insertSch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #datel {
            z-index: 1;
            left: 280px;
            top: 226px;
            position: absolute;
        }
        #datel2 {
            z-index: 1;
            left: 652px;
            top: 227px;
            position: absolute;
        }
    </style>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 552px; top: 229px; position: absolute; width: 80px; right: 626px;" Text="学校地址"></asp:Label>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 92px; position: absolute; height: 63px; width: 313px; right: 926px;" Text="插入学校" Font-Bold="True" Font-Italic="True" Font-Size ="50px"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 175px; top: 229px; position: absolute; height: 21px;" Text="学校名"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 1091px; top: 221px; position: absolute; height: 34px; width: 92px;" Text="返回" Font-Size="Large" />
        <p>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" style="z-index: 1; left: 182px; top: 299px; position: absolute; height: 139px; width: 241px">
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
        </p>
        <asp:Button ID="Button3" runat="server" Font-Size="Large" OnClick="Button3_Click" style="z-index: 1; left: 933px; top: 223px; position: absolute; height: 33px; width: 98px" Text="新建" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 253px; top: 225px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 646px; top: 226px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>

