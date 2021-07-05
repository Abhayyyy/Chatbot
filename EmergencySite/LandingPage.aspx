<%@ Page 
    Title="Landing Page" 
    Async="true"
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="LandingPage.aspx.cs" 
    Inherits="EmergencySite.LandingPage" %>

<%@ Register Assembly="BotDetect" Namespace="BotDetect.Web.UI"
    TagPrefix="BotDetect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Portfolio Website</title>
    <link href="https://cdn.jsdelivr.net/npm/remixicon@2.5.0/fonts/remixicon.css" rel="stylesheet">
    <link rel="stylesheet" href="style.css">
</head>
<body>

    <div id="loader">
        <div id="wrapperload">
            <div class="elem">
                <img src="./imgs/newname1.jpg" alt="" />
            </div>
            <div class="elem">
                <h3>C# and Java Developer</h3>
            </div>
            <div class="elem">
                <h3>loves to help brands.</h3>
            </div>
            <div class="elem">
                <img src="./imgs/newname1.jpg" alt="">
            </div>
        </div>
    </div>

    <div id="bg" style="margin:-7% 0% 0% -3%;">
        <nav>
            <img class="navitem" src="Images/info_crux.PNG" alt="">
            <div id="links">
                <a class="navitem" href="LandingPage.aspx">Home</a>
                <a class="navitem" href="#">Contact</a>
                <i class="navitem ri-search-line"></i>
                <i id="menu" class="navitem ri-menu-2-line"></i>
            </div>
        </nav>
        <div id="sections">
            <img class="leftitem" id="splash" src="./imgs/rightSplash.png" alt="">
            <div id="left">
                <div id="smline"></div>
                <%--<img class="leftitem" src="./imgs/newname1.jpg" alt="">--%>
                <p style="color:royalblue;font-size:143%;">ABHAY GUPTA</p>
                <h5 class="leftitem">a developer from <span id="lblue">India.</span></h5>
                <div class="leftitem" id="playbtn">
                    <img src="./imgs/playButton.png" alt="">
                    <a href="LandingPart2.aspx"><h5>go to <span class="bold">Emergency Site</span></h5></a>
                </div>
                <div class="leftitem" id="contact">
                    <h3>Contact me</h3>
                    <h6>Email : <span>abhaygupta070@gmail.com</span></h6>
                    <h6>Contact Number: <span>+91-7905777374</span></h6>
                </div>
            </div>
            <div id="right">
                <img src="./imgs/mainImage.png" alt="">
            </div>
        </div>
    </div>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.5.1/gsap.min.js" integrity="sha512-IQLehpLoVS4fNzl7IfH8Iowfm5+RiMGtHykgZJl9AWMgqx0AmJ6cRWcB+GaGVtIsnC4voMfm8f2vwtY+6oPjpQ==" crossorigin="anonymous"></script>
    <script src="script.js"></script>

    <script>
        var menu = document.querySelector('#menu');
        var bg = document.querySelector('#bg');

        menu.addEventListener('click', function () {
            bg.style.transform = 'scale(.8)';
            bg.style.borderRadius = '10px';
            bg.style.boxShadow = '0 150px 45px -100px rgba(0,0,0,0.2)';
        })
    </script>
</body>
</html>

  <%--<asp:Image ImageUrl="~/Images/4.jpg" ImageAlign="Left"   Width="200%"  Height="200%" runat="server" />--%> 
</asp:Content>
