<%@ Page 
    Title="" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="TestingFile.aspx.cs" 
    Inherits="EmergencySite.Testing.TestingFile" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div style="text-align: center;">
            <h3>
                <asp:Label ID="Label1" runat="server" Font-Bold="true" ForeColor="Black" Style="text-align: center" Text="Click the button below to encrypt all the passwords"> </asp:Label>
            </h3>
            <asp:Button ID="btnEButton" runat="server" BackColor="YellowGreen" Font-Bold="true" Text="Encrypt" OnClick="EButton_Click" />
        </div>
    </div>

</asp:Content>
