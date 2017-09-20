<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestRequestEntryUI.aspx.cs" Inherits="diagnosticCenterAPP.UI.TestRequestEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Entry With Test</title>
    <script src="../Script/jquery-3.1.1.min.js"></script>
    <script src="../Script/jquery-3.1.1.js"></script>

    
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }

        .auto-style2 {
            height: 26px;
            width: 126px;
        }

        .auto-style3 {
            width: 126px;
        }

        .auto-style4 {
            height: 26px;
            width: 91px;
        }

        .auto-style6 {
            width: 91px;
        }

        .auto-style7 {
            height: 26px;
            width: 361px;
        }

        .auto-style8 {
            width: 361px;
        }
    </style>

</head>
<body style="width: 536px; margin: auto;">
    <form id="form1" runat="server">
        <div>

            <fieldset>
                <legend>Test Entry Request</legend>

                <table style="width: 96%;">
                    <tr>
                        <td class="auto-style2">Name</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="userNameTB" runat="server"></asp:TextBox></td>
                        <td class="auto-style3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label2" runat="server" Text="Mobile"></asp:Label></td>
                        <td class="auto-style1">
                            <asp:TextBox ID="mobilTB" runat="server"></asp:TextBox></td>
                        <td class="auto-style3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label3" runat="server" Text="Date of Birth"></asp:Label></td>
                        <td class="auto-style1">
                            <asp:TextBox ID="dateOfBirthTB" runat="server" ></asp:TextBox></td>

                        <td class="auto-style3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label></td>
                        <td class="auto-style1">
                            <asp:TextBox ID="addressTB" runat="server"></asp:TextBox></td>
                        <td class="auto-style3">
                            <asp:Button ID="addUserBT" runat="server" Text="Add User" OnClick="addUserBT_Click" />
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label1" runat="server" Text="Test Name"></asp:Label>
                        </td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="testNameDropDownList" runat="server" Width="128px" FindByText="Yourvalue" Selected="true"></asp:DropDownList>
                        </td>
                        <td class="auto-style3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td class="auto-style1">
                            <asp:Label ID="Label5" runat="server" Text="Fee"></asp:Label>
                            <asp:TextBox ID="feeTB" runat="server" Width="84px" Enabled="False"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:HiddenField ID="SNHiddenField" runat="server" />
                        </td>
                        <td class="auto-style1">
                            <asp:Button ID="addBT" runat="server" Text="Add" OnClick="addBT_Click" />
                        </td>
                        <td class="auto-style3">
                            <asp:Label ID="resultLB" runat="server" Text=""></asp:Label></td>
                    </tr>


                </table>

            </fieldset>
            <asp:GridView ID="ShowGridView" runat="server" Width="532px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <br />
            <table style="width: 89%;">
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style4">Total</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="totalTB" runat="server" Text="0" Enabled="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="SaveBT" runat="server" Text="Save" OnClick="SaveBT_Click" /></td>
                    <td>
                        <asp:Label ID="TestIdLB" runat="server" Text=""></asp:Label></td>
                </tr>

            </table>



        </div>
    </form>
</body>
</html>
