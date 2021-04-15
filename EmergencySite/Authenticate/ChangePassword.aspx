<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs"
    Inherits="EmergencySite.Authenticate.ChangePassword" %>

<%@ Register Assembly="BotDetect" Namespace="BotDetect.Web.UI"
    TagPrefix="BotDetect" %>

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
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    </head>

    <body style="background:#286090;">
        <div class="authentication">
            <div class="otp-verification">
                <p class="">OTP Verification</p>
            </div>

            <form id="form1" runat="server">

                <asp:Label ID="lblEmail" runat="server" Style="color:#f4efef;" Text="Enter Your E-mail"
                    Font-Bold="True"></asp:Label>
                <asp:TextBox ID="txtEmail" class="form-control" runat="server" Width="300px" TextMode="Email">
                </asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Please anter your E-mail." ForeColor="Tomato"
                    ControlToValidate="txtEmail" runat="server" />
                <br />

                <asp:Label ID="lblNewPassword" runat="server" Style="color:#f4efef;" Text="New password"
                    Font-Bold="True"></asp:Label>
                <asp:TextBox ID="txtNewPassword" class="form-control" runat="server" Width="300px" TextMode="Password">
                </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Tomato" runat="server"
                    ControlToValidate="txtNewPassword" Style="color:#f4efef;" ErrorMessage="Please enter New password.">
                </asp:RequiredFieldValidator>
                <br />

                <asp:Label ID="lblConfirmPassword" runat="server" Style="color:#f4efef;" Text="Confirm password"
                    Font-Bold="True"></asp:Label>
                <asp:TextBox ID="txtConfirmPassword" class="form-control" runat="server" Width="300px"
                    TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Tomato" runat="server"
                    ControlToValidate="txtCOnfirmPassword" Style="color:#f4efef;"
                    ErrorMessage="Please enter Confirm password."></asp:RequiredFieldValidator>
                <br />

                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtNewPassword"
                    ForeColor="Tomato" ControlToValidate="txtConfirmPassword" Style="color:#f4efef;"
                    ErrorMessage="Password did not matched."></asp:CompareValidator>
                <br>

                <div>
                    <br />
                    <tr>
                        <asp:Label Text="Security Code :" Font-Bold="true" Font-Size="Larger" runat="server" />
                        <td>
                            <div style="padding-left: 90px">
                                <script>
                                    $(document).ready(function () {
                                        $("a[title ~= 'BotDetect']").removeAttr("style");
                                        $("a[title ~= 'BotDetect']").removeAttr("href");
                                        $("a[title ~= 'BotDetect']").css('visibility', 'hidden');
                                    });
                                </script>
                                <BotDetect:WebFormsCaptcha SoundEnabled="false" ID="CaptchaId" runat="server" UserInputID="txtCaptcha" />
                                <asp:TextBox ID="txtCaptcha" CssClass="form-control" runat="server" Width="250px" />[Type Security code here]
                            </div>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Label ID="lblMessage" runat="server" />
                        </td>
                    </tr>
                </div>

                <%-- <asp:Label Font-Bold="true" CssClass="form-group"
                    Text="Please enter the letters and numbers from the picture below." runat="server" />
                <br />
                <asp:TextBox ID="txtCaptchaCode" Width="300px" class="form-control" runat="server" />
                <br />
                <asp:Image ImageUrl="~/UI/CaptachRender.aspx" runat="server" />
                <asp:Label ID="lblMessage" Font-Bold="True" runat="server" Text=""></asp:Label><br />
                <br />
                <asp:RequiredFieldValidator ErrorMessage="Please enter a security code." ForeColor="Tomato"
                    ControlToValidate="txtCaptchaCode" runat="server" />
        </div>--%>
        <br />
        <asp:HiddenField ID="hdnLatitude" runat="server" />
        <asp:HiddenField ID="hdnLongitude" runat="server" />
        <asp:HiddenField ID="hdnLoginRid" runat="server" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
        </form>
        </div>
    </body>

    </html>