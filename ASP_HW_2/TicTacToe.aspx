<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="TicTacToe.aspx.cs" Inherits="TicTacToe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="Styles/TTTStyleSheet.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="Current player is X."></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
      

    <div id="container" runat="server" aria-disabled="False">

        <div class="bottom right">
                    <asp:Button ID = "Button1" runat="server" Text="" onClick ="UpdateInstruction" />
                    <img id="Img1" runat="server"/>
                </div>
                <div class="bottom left right">
                    <asp:Button ID = "Button2" runat="server" Text="" onClick ="UpdateInstruction" />
                    <img id="Img2" runat="server"/>
                </div>

                <div class="bottom left">
                    <asp:Button ID = "Button3" runat="server" Text="" onClick ="UpdateInstruction" />
                    <img id="Img3" runat="server"/>
                </div>
            

            <div class="bottom right top">
                    <asp:Button ID = "Button4" runat="server" Text="" onClick ="UpdateInstruction" />
                    <img id="Img4" runat="server"/>
                </div>
                <div class="bottom left right top">
                    <asp:Button ID = "Button5" runat="server" Text="" onClick ="UpdateInstruction" />
                    <img id="Img5" runat="server"/>
                </div>

                <div class="bottom left top">
                    <asp:Button ID = "Button6" runat="server" Text="" onClick ="UpdateInstruction"/>
                    <img id="Img6" runat="server"/>
                </div>
           

            <div class="top right ">
                    <asp:Button ID = "Button7" runat="server" Text="" onClick ="UpdateInstruction" />
                    <img id="Img7" runat="server"/>
                </div>
                <div class="top left right">
                    <asp:Button ID = "Button8" runat="server" Text="" onClick ="UpdateInstruction" />
                    <img id="Img8" runat="server"/>
                </div>

                <div class="top left">
                    <asp:Button ID = "Button9" runat="server" Text="" onClick ="UpdateInstruction"/>
                    <img id="Img9" runat="server"/>
                </div>
       
    </div>

    </asp:Content>
