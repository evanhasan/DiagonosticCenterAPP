<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestTypeUI.aspx.cs" Inherits="diagnosticCenterAPP.UI.TestTypeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <fieldset style="width: 594px; margin: auto;">
            <legend>Test Type Add</legend>
            Test Type Name:<asp:TextBox ID="testTypeNameTB" runat="server" Width="304px"></asp:TextBox>
            <asp:Button ID="SaveTestTypeBT" runat="server" Text="Add" OnClick="SaveTestTypeBT_Click" Width="59px" />
            <asp:Label ID="showMessageLB" runat="server" Text=""></asp:Label>
            <br/><br/>
            <asp:GridView ID="ShoeAllGridView" runat="server" Width="589px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
        </fieldset>

    </div>
        
    </form>
</body>
</html>
