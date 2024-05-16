<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="Styles/Login.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label2" runat="server" Text="Welcome to the Tic-Tac-Toe Game!" Font-Bold="True" Font-Size="X-Large"></asp:Label>

        </ContentTemplate>
    </asp:UpdatePanel>


    



    <% if (Session["SessionID"] == null)
        { %>

    <asp:Panel ID="Panel1" runat="server" Visible="true">
        <p>Register or Login to play the game.</p>
        <asp:Label ID="NameLabel" runat="server" Text="Enter username: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <br />

        <asp:Label ID="PasswordLabel" runat="server" Text="Enter password: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>


    </asp:Panel>
    <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="LoginButton_Click" />

    <% }
        else
        { %>
    <asp:Button ID="LogoutButton" runat="server" Text="Log out" OnClick="LogoutButton_Click" />
    <%} %>

    <br />
    <br />


    <div>
        <asp:Label ID="Label1" runat="server" Enabled="False"></asp:Label>
    </div>

    <p>Click <a href="About.aspx">here</a> for general information.</p>

</asp:Content>
