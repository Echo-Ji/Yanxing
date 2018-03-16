<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Yanxing.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv ="Content-Type" content ="text/html: charset=utf-8" />
    <title></title>
    <style type="text/css">
        #form1 {
            z-index: 1;
            left: 10px;
            top: 15px;
            position: absolute;
            height: 317px;
            width: 1266px;
        }
    </style>
</head>
<body style="background-image:url('背景6.jpg'); background-size:cover;height: 100%; width: 100%;">
    
   
      <form id="form1" runat="server">
                    <br /><br /><br />
                    <br /><br /><br />
                    <br />
                    <asp:Label ID="Label3" runat="server" ForeColor="#660033" style="z-index: 1; left: 1081px; top: 222px; position: absolute; height: 71px; width: 515px" Text="雁行中国信息管理平台" Font-Size="50px"></asp:Label>
                    <br /><br />

                    <p>
                    <asp:Label ID="Label1" runat="server" Text="用户：" style="z-index: 1; left: 1088px; top: 349px; position: absolute; height: 29px; width: 95px;" Font-Size="25px"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 1194px; top: 342px; position: absolute; height: 32px; width: 258px;" Font-Size="Large"></asp:TextBox>
                    </p>
                    <p>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" style="z-index: 1; left: 1194px; top: 410px; position: absolute; height: 32px; width: 258px;" Font-Size="Large"></asp:TextBox>
                    </p>
                    <p>
                    <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" style="z-index: 1; left: 1264px; top: 515px; position: absolute; height: 48px; width: 108px;" Font-Size="Large" />
                    </p>
                    <asp:Label ID="Label2" runat="server" Text="密码：" style="z-index: 1; left: 1088px; top: 419px; position: absolute" Font-Size="25px"></asp:Label>

      </form>

</body>
</html>
