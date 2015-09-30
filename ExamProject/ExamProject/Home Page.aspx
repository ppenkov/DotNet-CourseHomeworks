<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="ExamProject.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <style>
        .button {
            margin-left: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton Text="Country Statistics" runat="server" CssClass="button" PostBackUrl="~/Statistics.aspx" />
            <br />
            <br />
            <asp:Label Text="Country:" runat="server" ID="Country" />
            <asp:TextBox runat="server" ID="countryTxtBox" />
            <br />
            <br />
            <asp:Label Text="Capital" runat="server" ID="Capital" />
            <asp:TextBox runat="server" ID="capitalTxtBox" />
            <br />
            <br />
            <asp:Label Text="Population" runat="server" ID="population" />
            <asp:TextBox runat="server" ID="populationTxtBox" TextMode="Number" />
            <br />
            <br />
            <asp:Button Text="Submit" CssClass="my-button" runat="server" ID="submitBtn" OnClick="submitBtn_Click" />
        </div>
    </form>
</body>
</html>
