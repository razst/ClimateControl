<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoryPage.aspx.cs" Inherits="climate_IO.HistoryPage" EnableEventValidation="false" Async="true" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


                <script type="text/javascript">
                    window.onload = function () {
                        var rbl = document.getElementById("<%=filterRBbox.ClientID %>");
                        var radio = rbl.getElementsByTagName("INPUT");
                        for (var i = 0; i < radio.length; i++) {
                            radio[i].onchange = function () {
                                ShowHideValues(this.value);
                            };
                        }
                    };
</script>



<head runat="server">
        <meta charset='utf-8'/>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'/>
    <title>climate controll</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'/>
    <!-- <link rel='stylesheet' type='text/css' media='screen' href='main.css'> -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.css"/>
    <link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet"/>
    <!-- <script src='main.js'></script> -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src='https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.js'></script>
    <style>
        .nav-link:hover {
            background-color: aqua;
        }
    </style>

    <script type="text/javascript">
        function ShowHideValues(valueType) {
            var humidityValues = document.getElementById("humidityValues");
            var temperatureValues = document.getElementById("temperatureValues");
            var dateValues = document.getElementById("dateValues");
            if (valueType == 'Humidity') {
                humidityValues.style.display = "block";
                document.getElementById("minTempTxb").value = null;
                document.getElementById("maxTempTxb").value = null;
                document.getElementById("minDatePicker").value = null;
                document.getElementById("maxDatePicker").value = null;
            } else {
                humidityValues.style.display = "none";
            }
            if (valueType == 'Tempeture') {
                temperatureValues.style.display = "block";
                document.getElementById("minHumTxb").value = null;
                document.getElementById("maxHumTxb").value = null;
                document.getElementById("minDatePicker").value = null;
                document.getElementById("maxDatePicker").value = null;

            } else {
                temperatureValues.style.display = "none";
            }
            if (valueType == 'dates') {
                dateValues.style.display = "block";
                document.getElementById("minHumTxb").value = null;
                document.getElementById("maxHumTxb").value = null;
                document.getElementById("minTempTxb").value = null;
                document.getElementById("maxTempTxb").value = null;

            } else {
                dateValues.style.display = "none";

            }
        }

        function clear() {
            alert("hi");
            document.getElementById("minHumTxb").value = null;
            document.getElementById("maxHumTxb").value = null;
            document.getElementById("minTempTxb").value = null;
            document.getElementById("maxTempTxb").value = null;
            document.getElementById("minDatePicker").value = null;
            document.getElementById("maxDatePicker").value = null;

        }
    </script>
</head>
<body>
            <form id="historyPageFRM" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container-fluid">
        <ul class="nav  bg-white mb-0">
            <li class="nav-item">
                <a runat="server" onserverclick="Button1_Click" class="nav-link text-dark font-italic">
                    <i class="fa fa-home mr-3 text-primary fa-fw"></i>
                    Home
                </a>
            </li>
                            <li class="nav-item">
                    <a runat="server" class="nav-link text-dark font-italic"  >
                        <i class="fa fa-history mr-3 text-primary fa-fw"></i>
                        History
                    </a>
                </li>
            <li class="nav-item">
                <a href="#" class="nav-link text-dark font-italic">
                    <i class="fa fa-cog mr-3 text-primary fa-fw"></i>
                    Setting
                </a>
            </li>
        </ul>
        <div class="row ">
            <div class="col-3 container">
                <div style="width: 102%; height: 400px; overflow: scroll" class="row ">
                    <asp:GridView ID="dataGridView1" runat="server" AllowSorting="True" Height="445px" style="margin-top: 6px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="265px" >
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </div>
                <div class="row ">
                    <div class="col-6 py-3">
                        <legend>Filtred by:</legend>
                        <asp:RadioButtonList ID="filterRBbox" runat="server" Height="74px" >
                            <asp:ListItem Selected="True">Humidity</asp:ListItem>
                            <asp:ListItem>Tempeture</asp:ListItem>
                            <asp:ListItem>dates</asp:ListItem>
                        </asp:RadioButtonList>

                    </div>
                    <div id="humidityValues" class="col-6 py-3">
                        <legend>Values:</legend>
                        <div class="form-group row">
                            <label for="inputPassword" class="col-sm-3 col-form-label">From</label>
                            <asp:TextBox ID="minHumTxb" runat="server" TextMode="Number" placeholder="minimal humidity"></asp:TextBox>
                        </div>
                        <div class="form-group row">
                            <label for="inputPassword" class="col-sm-3 col-form-label">To</label>
                            <asp:TextBox ID="maxHumTxb" runat="server" TextMode="Number" placeholder="maximal humidity"></asp:TextBox>
                        </div>
                    </div>
                    <div id="temperatureValues" class="col-6 py-3" style="display: none;">
                        <legend>Values:</legend>
                        <div class="form-group row">
                            <label for="inputPassword" class="col-sm-3 col-form-label">From</label>
                            <asp:TextBox ID="minTempTxb" runat="server" TextMode="Number" placeholder="minimal tempeture"></asp:TextBox>
                        </div>
                        <div class="form-group row">
                            <label for="inputPassword" class="col-sm-3 col-form-label">To</label>
                            <asp:TextBox ID="maxTempTxb" runat="server" TextMode="Number" placeholder="maximal tempeture" ></asp:TextBox>
                        </div>
                    </div>
                    <div id="dateValues" class="col-6 py-3" style="display: none;">
                        <legend>Values:</legend>
                        <div class="form-group row">
                            <label for="inputPassword" class="col-sm-3 col-form-label">From</label>
                            <asp:TextBox ID="minDatePicker" runat="server" TextMode="Date"></asp:TextBox>
                        </div>
                        <div class="form-group row">
                            <label for="inputPassword" class="col-sm-3 col-form-label">To</label>
                            <asp:TextBox ID="maxDatePicker" runat="server" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-group col-12">
                        <legend for="inputState">Items</legend>
                        <ajaxToolkit:ComboBox ID="limitsCB" runat="server" DropDownStyle="DropDownList">
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem Selected="True">100</asp:ListItem>
                            <asp:ListItem>200</asp:ListItem>
                            <asp:ListItem>no limit</asp:ListItem>
                         </ajaxToolkit:ComboBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-6 ">
                        <input class="btn btn-primary" type="button" value="Clear" onclick="clear"/>
                    </div>
                    <div class="col-6 ">
                        <input runat="server" class="btn btn-primary" type="button" value="Show" onserverclick="OKbutton_Click"/>
                    </div>
                </div>
            </div>
            <div class="col-9 " style="background-color: cyan;">
                <asp:Chart ID="chart1" runat="server" Width="1221px" style="margin-left: 0px"><series>
                <asp:Series ChartArea="ChartArea1" ChartType="FastLine" Name="Tempeture">
                </asp:Series>
                <asp:Series Name="Humiditiy" ChartType="FastLine">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
            </div>
        </div>
    </div>
</form>
</body>
</html>
