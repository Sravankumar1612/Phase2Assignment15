<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebAppErrorHandling.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 358px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center">Calculator</h2>
            <table class="auto-style1">
                            
                <tr>
                    <td class="auto-style2">Enter First Number</td>
                    <td>
                        <asp:TextBox ID="TxtNum1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Enter Second Number</td>
                    <td>
                        <asp:TextBox ID="TxtNum2" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="LblErrorMessage" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="BtnDivision" runat="server" Text="Devide" OnClick="BtnDivision_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" id="BtnRedirect">
                        <asp:Button ID="BtnRedirect" runat="server" OnClick="BtnRedirect_Click" Text="RR" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
