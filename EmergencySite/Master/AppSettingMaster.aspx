<%@ Page 
    Async ="true"
    Title="" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="AppSettingMaster.aspx.cs" 
    Inherits="EmergencySite.Master.AppSettingMaster" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel 
        ID="UpdatePanel1" 
        runat="server" 
        RenderMode="Inline">
        <ContentTemplate> 
            <div class="container">
            <h2 style="text-align: center; font-weight: bold;">App setting</h2>
                    <asp:HiddenField ID="hdnAppSettingId" runat="server" />
                   <asp:checkbox 
                       ID ="cbSFAuthentication"
                       text="SFAuthentication" 
                       runat="server" />&nbsp;
                    <br /><br /><br />
                   <asp:button 
                       ID ="btnSubmit"
                       text="Submit" 
                       OnClick ="btnSubmit_Click"   
                       runat="server" />
        </div>
           <%--  <html>

<head>
    <script type="text/javascript" src="jquery-3.5.1.min.js"></script>

    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">

<!-- minified jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

<!-- minified Popper JS -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>

<!-- minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>

</head>

<body>
    <script type="text/javascript" src="../Scripts/Appsetting.js"></script>
    <section>
  <%--      <div class="container">
            <br>
        <h1 style="font-weight:bold; text-align: center;">App setting </h1>
        <br>
        <label for="chkPassport">
            <input type="checkbox" id="chkPassport" name="colorCheckbox" value="check" />
            <div id="diseble" style="display: none">
                Diseble
            </div>
            <div id="enable">
                Enable
            </div>
        </label>
        <hr>

        <div class="check box">
            hello
        </div>
       </div>--%>
  <%--  </section>

</body>

</html>--%>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
