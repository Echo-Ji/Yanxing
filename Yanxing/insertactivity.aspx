<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertactivity.aspx.cs" Inherits="Yanxing.insertactivity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script type =" text/javascript" src =" My97DatePicker/WdatePicker.js" ></script>
    <style type="text/css">
        .Wdate {
            z-index: 1;
            left: 652px;
            top: 459px;
            position: absolute;
        }
    </style>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <input runat="server" type =" text" class =" Wdate" onfocus="WdatePicker({lang:'zh-cn'})" id="datel" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 92px; position: absolute; height: 63px; width: 313px; right: 926px;" Text="插入活动" Font-Bold="True" Font-Italic="True" Font-Size ="50px"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 551px; top: 224px; position: absolute" Text="活动名称"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 1075px; top: 551px; position: absolute; height: 52px; width: 95px;" Text="返回" Font-Size="Large" />
        <p>
            &nbsp;</p>
        <asp:Button ID="Button3" runat="server" Font-Size="Large" OnClick="Button3_Click" style="z-index: 1; left: 684px; top: 554px; position: absolute; height: 50px; width: 110px; right: 577px;" Text="插入" />
        <asp:Label ID="Label22" runat="server" style="z-index: 1; left: 555px; top: 461px; position: absolute; height: 20px;" Text="活动时间"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 651px; top: 296px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 552px; top: 298px; position: absolute; height: 20px" Text="活动地点"></asp:Label>
        <asp:Label ID="Label24" runat="server" style="z-index: 1; left: 551px; top: 377px; position: absolute" Text="活动等级"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: 652px; top: 375px; position: absolute"></asp:TextBox>
       
        <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 651px; top: 221px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>