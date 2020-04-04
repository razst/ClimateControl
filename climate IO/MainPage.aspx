<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="climate_IO.MainPage" EnableEventValidation="false" Async="true" %>
 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset='utf-8'/>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'/>
    <title>Page Title</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'/>
    <link rel='stylesheet' type='text/css' media='screen' href='main.css'/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.css"/>
    <link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet"/>
    <script src='main.js'></script>
    <style>
        .main-frame {
            background-color: powderblue;
        }

        .main-frame {
            height: 100%;
        }

        .container-fluid {
            /* padding-top: 200px;
            padding-left: 300px;
            padding-right: 300px; */
        }

        .align-center {
            text-align: center;
        }

        .vertical-center {
            justify-content: center;
            line-height: 150px;
        }

        .deviation-center {
            display: flex;
            align-items: center;
            justify-content: center;

        }

        .deviation {
            width: 200px;
            height: 200px;
            /* border: 3px solid black; */
            border-radius: 50px;
        }

        .nav-link:hover {
            background-color: aqua;
        }

        .text-dicoration {
            font-size: x-large;
            font-weight: bold;
        }

        .value-dicoration {
            font-size: xx-large;
            font-weight: bold;
            top: 0px;
            left: 0px;
        }

        .py-10{
            padding-top: 6rem !important;
            padding-bottom: 6rem !important;
        }
    </style>
</head>

<body>
        <form id="mainPageFRM" runat="server">
    <div class="container-fluid">
        
            <ul class="nav  bg-white mb-0 pb-5">

                <li class="nav-item">
                    <a runat="server" class="nav-link text-dark font-italic" onserverclick="Button2_Click" >
                        <i class="fa fa-history mr-3 text-primary fa-fw"></i>
                        History
                    </a>
                </li>
                                <li class="nav-item">
                    <a class="nav-link text-dark font-italic">
                        <i class="fa fa-cog mr-3 text-primary fa-fw"></i>
                        Setting
                    </a>
                </li>
            </ul>
        
        <div class="row align-center py-10">
            <div class="col=12 container">
                <div class="row">
                    <div class="col-2 deviation-center ">
                        <img src="https://pngimage.net/wp-content/uploads/2018/06/green-button-png-7.png"
                            class="deviation" alt="Deviation"/>
                    </div>
                    <div class="col-10 container main-frame vertical-center">
                        <div class="row ">
                            <div class="col-6 container">
                                <div class="row ">
                                    <div class="col-12 text-dicoration">
                                        Temperature:
                                    </div>
                                    <div class="col-12 value-dicoration">
                                        <asp:Label ID="curTemp" runat="server" Text="..."></asp:Label>
                                    </div>
                                </div>
                            </div>
                            <div class="col-6 container">
                                <div class="row ">
                                    <div class="col-12 text-dicoration">
                                        Humidity:
                                    </div>
                                    <div class="col-12 value-dicoration">
                                        <asp:Label ID="curHum" runat="server" Text="..."></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
     </form>
</body>

</html>
