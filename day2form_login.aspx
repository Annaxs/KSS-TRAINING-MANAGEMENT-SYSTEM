<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="day2form_login.aspx.cs" Inherits="WebApplication3.day2form_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                
                <tr>
                    <td>USER NAME</td>
                    <td>
                        <asp:Textbox ID="username" runat="server" />
                    </td>
                </tr>
                
                <tr>
                    <td>PASSWORD</td>
                    <td>
                        <asp:TextBox ID="password" TextMode="Password" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <center><asp:Button ID="submit" runat="server" Text="Login" OnClick="submit_Click" /></center>
                    </td>
                </tr>

            </table>

             <h3>"the user id statement has been updated"</h3>
        </div>
    </form>
</body>
</html>
