<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hello.aspx.cs" Inherits="Yanxing.hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv ="Content-Type" content ="text/html: charset=utf-8" />
    <title></title>
    <style>
        html,body { margin:0px; height:100%; } 
        .container { height: 100%;background-image:url(Images/wood.jpg); }
        .header {height:20%; width:100%; background-color:red; opacity: 0; text-align:center; font-size:36px; line-height:100px; top:0px; }
        .center {height:65%; width:100%; background-color:blue; opacity: 0; }
        .centerColumn1 {float:left; height:100%; width:20%; background-color:blueviolet; opacity: 0; position:fixed; left:0px; }
        .centerColumn2 {float:left; height:100%; width:100%; background-color:cadetblue; opacity: 0; text-align:center; position:fixed; }
        .centerColumn3 {float:left; height:100%; width:20%; background-color:cornflowerblue; opacity: 0; position:fixed; right:0px; }
        .footer {height:15%; width:100%; background-color:yellow; opacity: 1.0; position:fixed; bottom: 0px; }
    </style>
</head>
<body>
   
      <form id="form1" runat="server">
        <div class="header" >雁行中国信息管理系统</div>
        <div class="center" >
            <div class="centerColumn2" >
                <div >
                    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                    <asp:Label ID="Label1" runat="server" Text="用户："></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br /><br />
                    <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><br /><br /><br />
                    <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
                </div><br /><br />
                <asp:Label ID="echo_ashraf" runat="server" Text=""></asp:Label>
            </div>
            <div class="centerColumn1" >第1列</div>
            <div class="centerColumn3" >第3列</div>
         </div>
        <div class="footer" >不用管我是什么。。。</div>
      </form>

</body>
</html>
