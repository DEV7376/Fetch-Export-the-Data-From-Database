<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="ExportWork.loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 232px;
        }
    </style>
</head>
<body>
    <h1>LOGIN HERE</h1>
    <form id="form1" runat="server">
        <p>USER ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUser" runat="server" Height="30px" Width="290px"></asp:TextBox>
        </p>
        <p>PASSWORD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPass" runat="server" Height="30px" Width="293px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnLogin" runat="server" CssClass="auto-style1" OnClick="BtnLogin_Click" Text="LOGIN" Width="132px" />
        </p>
        <div>

        </div>
    </form>
</body>
</html>
