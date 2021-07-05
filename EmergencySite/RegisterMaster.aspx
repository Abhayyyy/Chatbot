<%@ Page 
    Async="true"
    Title="Register Page" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="RegisterMaster.aspx.cs" 
    Inherits="EmergencySite.RegisterMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:UpdatePanel 
        ID="UpdatePanel"
        runat="server">
        <ContentTemplate>
                <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <!------ Include the above in your HEAD tag ---------->
    
    <div class="sidenav">
        <div class="login-main-text">
            <%--<img height="100%" width="100%" src="Images/service4.png" alt=".." />--%>

            <%-------------------------------------------------%>
            <!DOCTYPE html>
            <html>
            <head lang="zh-cn">
                <meta charset="UTF-8">
                <meta name="viewport" content="width=640, target-densityDpi=device-dpi, user-scalable=no">
                <link rel="stylesheet" href="style.css" />
                <style>
                    .loading_text {
                        position: absolute;
                        left: 40%;
                        top: 45%;
                        transform: translate3d(-50%,-50%,0);
                        font-family: "microsoft yahei light",sans-serif;
                        text-align: center;
                        font-size: 30px;
                        z-index: 100;
                        text-shadow: 0 0 10px rgba(64,160,255,0.75);
                    }

                    strong {
                        font-family: "microsoft yahei",sans-serif;
                    }

                    .loading_box {
                        position: absolute;
                        top: 0;
                        width: 100%;
                        height: 100%;
                    }
                </style>
            </head>
            <body>
              
                <div class="main_body">
                    <div class="loading_text" style="padding-top:20%">
                        <strong>Emergency Site</strong><br />
<%--                        <p>Login or register from here to access.</p>--%>
                        Stay Safe</br><strong>Maintain Social Distancing</strong></div>
                    <div class="loading_box" id="loading_box">
                        <canvas id="loading"></canvas>
                    </div>
                </div>
                <script src="dat.gui.min.js"></script>
                <script src="../particles.js"></script>
                <script>
                    (function () {
                        var ml = mapleParticles(document.getElementById("loading"));
                        var gui = new dat.GUI();
                        gui.add(ml.config, 'num', 0, 5000).step(1);
                        var sizeFolder = gui.addFolder("Size")
                        sizeFolder.add(ml.config.size, "minSize", 0, 500)
                        sizeFolder.add(ml.config.size, "maxSize", 0, 500)

                        var zoneFolder = gui.addFolder("Zone");
                        zoneFolder.add(ml.config.zone.x, 0, -1, 2).name("startX").step(0.001);
                        zoneFolder.add(ml.config.zone.x, 1, -1, 2).name("endX").step(0.001);
                        zoneFolder.add(ml.config.zone.y, 0, -1, 2).name("startY").step(0.001);
                        zoneFolder.add(ml.config.zone.y, 1, -1, 2).name("endY").step(0.001);

                        var speedFolder = gui.addFolder("Speed");
                        speedFolder.add(ml.config.speed.x, 0, -10, 10).name("minSpeedX").step(0.01);
                        speedFolder.add(ml.config.speed.x, 1, -10, 10).name("maxSpeedX").step(0.01);
                        speedFolder.add(ml.config.speed.y, 0, -10, 10).name("minSpeedY").step(0.01);
                        speedFolder.add(ml.config.speed.y, 1, -10, 10).name("maxSpeedY").step(0.01);
                        speedFolder.add(ml.config.speed.ax, 0, -5, 5).name("minAccX").step(0.01);
                        speedFolder.add(ml.config.speed.ax, 1, -5, 5).name("maxAccX").step(0.01);
                        speedFolder.add(ml.config.speed.ay, 0, -5, 5).name("minAccY").step(0.01);
                        speedFolder.add(ml.config.speed.ay, 1, -5, 5).name("maxAccY").step(0.01);

                        var timeFolder = gui.addFolder("Time")
                        timeFolder.add(ml.config.time, "fadeIn", 16, 10000).step(1);
                        timeFolder.add(ml.config.time, "fadeOut", 16, 10000).step(1);

                        var atmosphereFolder = gui.addFolder("Atmosphere");
                        var afC1 = atmosphereFolder.addFolder("Color1");
                        var afC2 = atmosphereFolder.addFolder("Color2")
                        afC1.addColor(ml.config.atmosphere[0], "start");
                        afC1.addColor(ml.config.atmosphere[0], "end");
                        afC2.addColor(ml.config.atmosphere[1], "start");
                        afC2.addColor(ml.config.atmosphere[1], "end");

                        gui.add(ml.config, "mode", ["lighter", "source-over", "multiply", "screen", "overlay", "darken", "hard-light", "soft-light"])
                        gui.addColor(ml.config, "background");
                        gui.add(ml.config, "atmosphereBG");
                        gui.add(ml.config, "follow");
                        gui.add(ml.config, "active");
                        gui.add(ml.config, "perspective");
                        gui.add(ml.config, "sizeToZLevel");
                        gui.add(ml.config, 'blur');
                    })()

                </script>
            </body>
            </html>

            <style>
                *,
                *:before,
                *:after {
                    margin: 0;
                    padding: 0;
                    box-sizing: border-box;
                }

                body {
                    background: #111;
                    color: #fff;
                    font-family: "Microsoft Yahei ", "微软雅黑", sans-serif;
                }

                .loading_text {
                    pointer-events: none;
                }

                .loading_box {
                    position: relative;
                    margin: 0 auto;
                    overflow: hidden;
                }

                    .loading_box canvas {
                        display: block;
                        height: 100%;
                        width: 100%;
                    }

                .dg.ac *,
                .dg.ac *:before,
                .dg.ac *:after {
                    box-sizing: content-box;
                }
            </style>
            <%-------------------------------------------------%>
        </div>
    </div>
    <div class="main">
            <div class="login-form">
                <form >
                    <div class="form-group" >
                        <asp:Label ID="UserId" Font-Bold="true" Font-Size="Small" runat="server" Text="User Name"></asp:Label>
                        <br>
                        <asp:TextBox ID="txtUsernameId" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                        <br>
                        <br>
                            
                        <asp:Label ID="lblFirstPass" Font-Bold="true" Font-Size="Small" runat="server" Text="Enter Password"></asp:Label>
                        <br>
                        <asp:TextBox ID="txtFirstPass" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
                        <br>
                        <br>
                        
                        
                        <asp:Label ID="lblSecondPass" Font-Bold="true" Font-Size="Small" runat="server" Text="Re-Enter Password"></asp:Label>
                        <br>
                        <asp:TextBox ID="txtSecondPass" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div style="width:60%">
                        <asp:Button
                        ID="btnRegister"
                        BackColor="#8f2805"
                        BorderStyle="None"
                        CssClass="roundCorner; button; float-left"
                        Font-Bold="false"
                        ForeColor="White"
                        runat="server"
                        Text="Register"
                        OnClick="btnRegister_Click" Style="height: 30px; width: 80px" />
                    <asp:Button
                        ID="btnLogin"
                        BackColor="#8f2805"
                        BorderStyle="None"
                        CssClass="roundCorner; button; float-right"
                        Font-Bold="false"
                        ForeColor="White"
                        runat="server"
                        Text="Login"
                        OnClick="btnLogin_Click" Style="height: 30px; width: 80px" />
                    </div>
                    <br />
                </form>
            </div>
        </div>
    </div>

    <style>
        body {
            font-family: "Lato", sans-serif;
        }

        .roundCorner {
            background-color: #4CAF50; /* Green */
            border: none;
            color: white;
            padding: 20px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
        }

        .button {
            border-radius: 8px;
        }
        .login-form{
            padding: 0% 0% 0% 35% !important;
        }
        .form-group {
    margin-bottom: 34px!important;
}

        .main-head {
            height: 150px;
            background: #FFF;
        }

        .sidenav {
            background-color: black;
            background-image:url("~/Images/service4.png");
            width: 100%;
            height: 100%;

        }


        .main {
            padding: 0px 10px;
        }

        @media screen and (max-height: 450px) {
            .sidenav {
                padding-top: 15px;
            }
        }

        @media screen and (max-width: 450px) {
            .login-form {
                margin-top: 10%;
            }

            .register-form {
                margin-top: 10%;
            }
        }

        @media screen and (min-width: 768px) {
            .main {
                margin-left: 40%;
            }

            .sidenav {
                width: 40%;
                position: fixed;
                z-index: 1;
                top: 0;
                left: 0;
            }

            .login-form {
                margin-top: 20%;
            }

            .register-form {
                margin-top: 20%;
            }
        }


        .login-main-text {
            margin-top: 20%;
            padding: 60px;
            color: #fff;
        }

            .login-main-text h2 {
                font-weight: 300;
            }

        .btn-black {
            background-color: #000 !important;
            color: #fff;
        }
    </style>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
