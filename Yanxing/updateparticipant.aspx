<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateparticipant.aspx.cs" Inherits="Yanxing.updateparticipant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script type =" text/javascript" src =" My97DatePicker/WdatePicker.js" ></script>
    <style type="text/css">
        #datel {
            z-index: 1;
            left: 653px;
            top: 409px;
            position: absolute;
        }
    </style>
</head>
<body style="background-image:url('背景7.jpg'); background-size:cover;height: 100%; width: 100%;">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label20" runat="server" style="z-index: 1; left: 513px; top: 285px; position: absolute" Text="学生用户id"></asp:Label>
    
    </div>
        <input runat="server" type =" text" class =" Wdate" onfocus="WdatePicker({lang:'zh-cn'})" id="datel" />
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 652px; top: 221px; position: absolute" ></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 117px; top: 92px; position: absolute; height: 63px; width: 313px; right: 926px;" Text="插入活动参与" Font-Bold="True" Font-Italic="True" Font-Size ="50px"></asp:Label>
        <asp:Label ID="Label21" runat="server" style="z-index: 1; left: 551px; top: 224px; position: absolute" Text="活动id"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 1073px; top: 491px; position: absolute; height: 52px; width: 95px;" Text="返回" Font-Size="Large" />
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 652px; top: 282px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Font-Size="Large" OnClick="Button3_Click" style="z-index: 1; left: 683px; top: 491px; position: absolute; height: 50px; width: 110px; right: 564px;" Text="更新" />
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 653px; top: 344px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label22" runat="server" style="z-index: 1; left: 554px; top: 347px; position: absolute; bottom: 188px;" Text="角色id"></asp:Label>
        <asp:Label ID="Label23" runat="server" style="z-index: 1; left: 539px; top: 412px; position: absolute" Text="活动时间"></asp:Label>
    </form>
</body>
</html>

