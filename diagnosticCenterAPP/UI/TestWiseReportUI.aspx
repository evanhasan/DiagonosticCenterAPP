<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWiseReportUI.aspx.cs" Inherits="diagnosticCenterAPP.UI.TestWiseReportUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test Wise Report</title>
    <script src="../Script/jquery-3.1.1.js"></script>
    <script src="../Script/jquery-3.1.1.min.js"></script>
    <script src="../Script/jquery-ui.js"></script>
    <script src="../Script/jquery-ui.min.js"></script>
    <link href="../Styles/jquery-ui.min.css" rel="stylesheet" />
    <link href="../Styles/jquery-ui.css" rel="stylesheet" />
    
    <script type="text/javascript">
        
        $(function() {
            $("#fromDateTB").datepicker();
            $("#toDateTB").datepicker();
        })

    </script>
    <style type="text/css">
        
        .ui-datepicker {
            background: aquamarine;
        }
         .auto-style1 {
             width: 256px;
         }
        .auto-style2 {
            width: 326px;
        }
        .auto-style3 {
            width: 209px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 552px">
    <fieldset>
        <legend>Test Wise Report</legend>
        <table style="width: 65%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="From Date"></asp:Label></td>
                <td class="auto-style3">
                    <asp:TextBox ID="fromDateTB" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="To Date"></asp:Label></td>
                <td class="auto-style3">
                    <asp:TextBox ID="toDateTB" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td> </td>
                <td class="auto-style3">
                    <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" /> 
                    <asp:Label ID="resultLB" runat="server" Text=""></asp:Label>
                </td>
                <td></td>
            </tr>
        </table> 
        <asp:GridView ID="ResultGridView" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="415px">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        
        <table style="width: 67%;">
            <tr>
                <td class="auto-style2">PDF</td>
                <td>Total</td>
                <td class="auto-style1">
                    <asp:TextBox ID="totalTB" runat="server"></asp:TextBox></td>
            </tr>
         
        </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
