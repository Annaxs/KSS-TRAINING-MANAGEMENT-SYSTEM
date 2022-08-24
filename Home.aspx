<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication3.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>"YOU ARE AT THE HOME PAGE NOW!!!!!!!!!!"</h1>
        <div>
            <table>
                <tr>
                    <td>Enter UserName</td>
                    <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter Password</td>
                    <td><asp:TextBox ID="txtPwd" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"></asp:Button></td>
                </tr>
            </table>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">


            </asp:GridView>
        </div>
    </form>
</body>
</html>
