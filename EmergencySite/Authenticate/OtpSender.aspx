<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="OtpSender.aspx.cs" Inherits="EmergencySite.Authenticate.Message" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Emergency Site</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
        <link href="../Styles/Style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body style="background:#286090;">
        <div class="authentication" style="padding : 5% 4% 5% 38%;">
            <div class="otp-verification">
            <p class="" style ="color : navajowhite; font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; font-size : 160%">OTP VERIFICATION</p>
        
                <form runat="server" >
                    <asp:ScriptManager ID="ScriptManager1" runat="server" />
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <div>
                                <asp:Label Font-Bold="true" Style="color: #f4efef;" Text="Enter your E-mail:" runat="server" />
                                <asp:TextBox ID="txtEmail" Width="260px" class="form-control" TextMode="Email" runat="server" />
                                <asp:RequiredFieldValidator ErrorMessage="Please enter your E-mail." ControlToValidate="txtEmail" ForeColor="Tomato" runat="server" />
                            </div>
                            <asp:Button ID="btnSendOTP" runat="server" CssClass="button" Text="Send OTP" OnClick="btnSendOTP_Click" OnClientClick="disableButton();" UseSubmitBehavior="false" />
                            <br />
                            <br />
                            <div>
                                <asp:Label Font-Bold="true" Text="Enter an OTP:" runat="server" style="color: #f4efef;" />
                                <asp:TextBox ID="txtOtp" Width="260px" class="form-control" TextMode="Number" runat="server" />
                            </div>
                            <br />
                            <div>
                                <asp:Button ID="btnVerify" Text="Verify" runat="server" OnClick="btnVerify_Click" />
                            </div>
                            <asp:HiddenField ID="hdnLatitude" runat="server" />
                            <asp:HiddenField ID="hdnLongitude" runat="server" />
                            <asp:HiddenField ID="hdnLoginRid" runat="server" />
                            <br />

                            <script type="text/javascript">
                                function disableButton() {
                                    if (document.getElementById('<%= txtEmail.ClientID %>').value != '') {
                                        document.getElementById('<%= btnSendOTP.ClientID %>').disabled = true;
                                    }
                                }
                            </script>

                 <%--           <script type="text/javascript">
                                function disableButton() {
                                    if (document.getElementById('<%= txtEmail.ClientID %>').value != '') {
                                        document.getElementById('<%= btnSendOTP.ClientID %>').disabled = true;
                                        setTimeout(function () {
                                            document.getElementById('<%= btnSendOTP.ClientID %>').disabled = false;
                                        }, 60000);
                                    }
                                }--%>

                               <%-- var c = 60;
                                var t;
                                function timedCount() {
                                    if (document.getElementById('<%= txtEmail.ClientID %>').value != '') {
                                        document.getElementById("txtCountDown").value = "Time remaining " + c + " seconds";
                                        c = c - 1;
                                        if (c < 0) {
                                            document.getElementById("txtCountDown").value = "";
                                            clearTimeout(t);
                                            return false;
                                        }
                                        t = setTimeout(timedCount, 1000);
                                    }
                                }--%>
                            <%--</script>--%>

                        </ContentTemplate>
                    </asp:UpdatePanel>
                </form>
            </div>
       </div>
</body>
</html>
