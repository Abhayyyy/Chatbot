<%@ Page 
    Language="C#" 
    AutoEventWireup="true" 
    Async="true" 
    CodeBehind="2FactorAuthentication.aspx.cs" 
    Inherits="EmergencySite.Authenticate._2FactorAuthentication" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>WE-SIS</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="../Styles/Style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    
</head>
<body style="background:#286090;">
        <div class="authentication">
            <div class="otp-verification">
            <p class="">Two-Factor Authentication</p>
        </div>
                <form runat="server">
                    <asp:ScriptManager ID="ScriptManager1" runat="server" />
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div>
                                <asp:Label Font-Bold="true" Style="color: #f4efef;"  Text="Enter your E-mail:" runat="server" />
                                <asp:TextBox ID="txtUsername" Width="260px" class="form-control" runat="server" />
                                <asp:RequiredFieldValidator ErrorMessage="Please enter your E-mail." ControlToValidate="txtUsername" ForeColor="Tomato" runat="server" />
                            </div>
                            <%--<asp:Button ID="btnSendOTP" runat="server" CssClass="button" Text="Send OTP" OnClick="btnSendOTP_Click" OnClientClick="disableButton(); timedCount();" UseSubmitBehavior="false" />--%>
                            <asp:Button ID="btnSendOTP" runat="server" CssClass="button" Text="Send OTP" OnClick="btnSendOTP_Click" OnClientClick="disableButton();" UseSubmitBehavior="false" />
                            <%--<asp:TextBox runat="server" Enabled="false" BackColor="White" ID="txtCountDown" BorderStyle="None" />--%>
                            <br />
                            <br />
                            <div>
                                <asp:Label style="color: #f4efef;" Text="Your login is protected with an authenticator app.<br>
                                    You've received an authentication code in the mail." runat="server" /><br /><br />
                                <asp:Label Font-Bold="true" style="color: #f4efef;" Text="Enter an OTP:" runat="server" />
                                <asp:TextBox ID="txtTwoFactorAuth" Width="260px" class="form-control" TextMode="Number" runat="server" />
                            </div>
                            <br />
                            <div>
                                <asp:Button ID="btnAuthVerify" Text="Verify" runat="server" OnClick="btnAuthVerify_Click" />
                            </div>
                            <asp:HiddenField ID="hdnLatitude" runat="server" />
                            <asp:HiddenField ID="hdnLongitude" runat="server" />
                            <asp:HiddenField ID="hdnLoginRid" runat="server" />

                            <script type="text/javascript">
                                function disableButton() {
                                    if (document.getElementById('<%= txtUsername.ClientID %>').value != '') {
                                        document.getElementById('<%= btnSendOTP.ClientID %>').disabled = true;
                                    }
                                }
                            </script>

                            <%--<script type="text/javascript">
                                function disableButton() {
                                    if (document.getElementById('<%= txtUsername.ClientID %>').value != '') {
                                        document.getElementById('<%= btnSendOTP.ClientID %>').disabled = true;
                                        setTimeout(function () {
                                            document.getElementById('<%= btnSendOTP.ClientID %>').disabled = false;
                                        }, 60000);
                                    }
                                }

                                var c = 60;
                                var t;
                                function timedCount() {
                                    if (document.getElementById('<%= txtUsername.ClientID %>').value != '') {
                                        document.getElementById("txtCountDown").value = "Time remaining " + c + " seconds";
                                        c = c - 1;
                                        if (c < 0) {
                                            document.getElementById("txtCountDown").value = "";
                                            clearTimeout(t);
                                            return false;
                                        }
                                        t = setTimeout(timedCount, 1000);
                                    }
                                }
                            </script>--%>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </form>
            </div>
</body>
</html>
