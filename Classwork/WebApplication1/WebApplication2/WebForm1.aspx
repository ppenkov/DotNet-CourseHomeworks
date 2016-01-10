<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="checkbox1" runat="server" OnCheckedChanged="checkbox1_CheckedChanged" AutoPostBack="true"/>
            <asp:DropDownList ID="dropList1" runat="server" OnSelectedIndexChanged="dropList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Roma" />
                <asp:ListItem Text="Levski" />
            </asp:DropDownList>
            <asp:Button ID="Button" runat="server" Text="Magic" OnClick="Button_Click" Enabled="false" />
        </div>
    </form>
</body>
</html>
