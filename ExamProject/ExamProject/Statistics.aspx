<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="ExamProject.Statistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Country Statistics</title>
    <style>
        .button {
            margin-left: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton Text="Home Page" runat="server" CssClass="button" PostBackUrl="~/Home Page.aspx" />
            <br />
            <br />
            <asp:Label Text="Country" runat="server" ID="Country" />
            <asp:TextBox runat="server" ID="countryTxtBox" />
            <asp:Button Text="Country Search" runat="server" ID="searchCountryBtn" OnClick="searchCountryBtn_Click"/>
            <asp:Label Text="" runat="server" ID="Label1" />
            <br />
            <br />
            <asp:Label Text="Capital" runat="server" ID="capital" />
            <asp:TextBox runat="server" ID="capitalTxtBox" />
            <asp:Button Text="Capital Search" runat="server" ID="searchCapitalBtn" OnClick="searchCapitalBtn_Click" />
            <asp:Label Text="" runat="server" ID="Label2" />
            <br />
            <br />
            <asp:Label Text="From:" runat="server" ID="searchPopulation" />
            <asp:TextBox runat="server" ID="searchPopulationTxtBox" TextMode="Number" />
            <asp:Label Text="To:" runat="server" ID="searchPopulation2" />
            <asp:TextBox runat="server" ID="searchPopulationTxtBox2" TextMode="Number" />
            <asp:Button Text="Population Search" runat="server" ID="searchPopulationBtn" OnClick="searchPopulationBtn_Click"/>
            <asp:Label Text="" runat="server" ID="Label3" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
