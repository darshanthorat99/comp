<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="comp.Information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 224px;
        }
        .auto-style3 {
            width: 551px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-bottom: 584px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">ID</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">NAME</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" Text="search" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">DOB</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtDob" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="delete" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">SEX</td>
                    <td class="auto-style3">
                        <asp:RadioButtonList ID="rbtsex" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">PHONE</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtPhone" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">ADDRESS</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="save" />
                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="update" />
                    </td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server" Text="msg"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
