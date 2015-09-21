<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormsHomework.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" runat="server" Text="User Name: "/>
            <asp:TextBox ID="TextBox1" runat="server"/><br/>
            <asp:Label ID="label2" runat="server" Text="Password: "/>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"/><br/>
            <asp:Label ID="label3" runat="server" Text="Repeat Password: "/>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"/><br/>
            <asp:Label ID="label4" runat="server" Text="Age: "/>
            <asp:TextBox ID="TextBox4" runat="server" /><br/>
            <asp:Label ID="label5" runat="server" Text="E-mail: "/>
            <asp:TextBox ID="TextBox5" runat="server"/><br/>
            <asp:Label ID="label6" runat="server"/><br/>
            <asp:Button ID="Button" runat="server" Text="Register" OnClick="Button_Click"/>
        </div>
    </form>
</body>
</html>
