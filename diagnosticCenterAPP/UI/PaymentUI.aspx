<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentUI.aspx.cs" Inherits="diagnosticCenterAPP.UI.PaymentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div >
    <fieldset style="width: 537px; margin: auto; ">
        <legend>Payment</legend>
        
        <asp:Label ID="Label1" runat="server" Text="Bill No"></asp:Label>
        <asp:TextBox ID="billNoTB" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
        <br/><br />
        <asp:GridView ID="testListGridView" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="512px">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <br/>
        <table style="width: 96%;">
            <tr>
                <td>Bill date</td>
                <td>
                    <asp:TextBox ID="billDateTB" runat="server" Enabled="False"></asp:TextBox>
                </td>               
            </tr>
            <tr>
                <td>Total Fee</td>
                <td>
                    <asp:TextBox ID="totalTB" runat="server" Enabled="False"></asp:TextBox>
                </td>             
            </tr>
            <tr>
                <td>Paid Amount</td>
                <td>
                    <asp:TextBox ID="paidAmountTB" runat="server" Enabled="False"></asp:TextBox>
                </td>                
            </tr>
             <tr>
                <td>Due Amount</td>
                <td>
                    <asp:TextBox ID="dueAmountTB" runat="server" Enabled="False"></asp:TextBox>
                 </td>                
            </tr>
             <tr>
                <td>Payment</td>
                <td>
                    <asp:TextBox ID="paymentTB" runat="server"></asp:TextBox></td>                
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="payBT" runat="server" Text="Pay" OnClick="payBT_Click" /> </td>                
            </tr>
        </table>
        

    </fieldset>
    </div>
    </form>
</body>
</html>
