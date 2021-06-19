<%@ Page Title="" Language="C#" MasterPageFile="~/Sales.Master" AutoEventWireup="true" CodeBehind="Salesmaster.aspx.cs" Inherits="_3layerweb.Salesmaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="h1header" runat="server">
    SALES DATA ENTRY
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="h2header" runat="server">
    <p>
        Sign out</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="h3header" runat="server">
     <form id="form5" runat="server">
    <table class="w-100">
        <tr>
            <td style="width: 348px; height: 48px;">
                <asp:Label ID="Label1" runat="server" Text="Reciept#"></asp:Label>
            </td>
            <td style="width: 408px; height: 48px;">
                <asp:TextBox ID="txtreciept" runat="server"></asp:TextBox>
            &nbsp;
                <asp:Button ID="Button9" runat="server" Text="Search" OnClick="Button9_Click" />
            </td>
            <td style="height: 48px"></td>
        </tr>
        <tr>
            <td style="width: 348px; height: 40px;">
                <asp:Label ID="Label2" runat="server" Text="Product Name"></asp:Label>
            </td>
            <td style="width: 408px; height: 40px;">
                <asp:DropDownList ID="DropDownList1" runat="server"   OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="184px" AutoPostBack="True">
              <asp:listitem text="Choose Name" value="0"></asp:listitem>
                     </asp:DropDownList>
            </td>
            <td rowspan="5">
                <asp:GridView ID="GridView1" runat="server" Height="179px" Width="309px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 348px; height: 50px;">
                <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            </td>
            <td style="width: 408px; height: 50px;">
                <asp:TextBox ID="txtprice" runat="server" OnTextChanged="txtprice_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 348px; height: 50px;">
                <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label>
            </td>
            <td style="width: 408px; height: 50px;">
                <asp:TextBox ID="txtstock" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 348px; height: 50px;">
                <asp:Label ID="Label5" runat="server" Text="Quantity"></asp:Label>
            </td>
            <td style="width: 408px; height: 50px;">
                <asp:TextBox ID="txtquantity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 348px; height: 50px;">
                <asp:Label ID="Label6" runat="server" Text="Date"></asp:Label>
            </td>
            <td style="width: 408px; height: 50px;">
                <asp:TextBox ID="txtdate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 348px; height: 50px;">
                <asp:Label ID="Label7" runat="server" Text="Sold By"></asp:Label>
            </td>
            <td style="width: 408px; height: 50px;">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="183px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    <asp:listitem text="Choose Sold by" value="0"></asp:listitem>
                </asp:DropDownList>
            </td>
            <td style="height: 50px">
                <asp:Button ID="Button7" runat="server" Text="Grid Refresh" OnClick="Button7_Click" />
&nbsp;
                <asp:Button ID="Button8" runat="server" Text="View All" OnClick="Button8_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 348px; height: 50px"></td>
            <td style="width: 408px; height: 50px">
                <asp:Label ID="lblout" runat="server" Text="_______!!!"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblout1" runat="server" Text="_______!!!"></asp:Label>
            </td>
            <td style="height: 50px">
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Employee" />
&nbsp;
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Product" />
&nbsp;
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Customer" />
            </td>
        </tr>
        <tr>
            <td style="width: 348px; height: 50px;"></td>
            <td style="width: 408px; height: 50px;">
                <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
            </td>
            <td style="height: 50px"></td>
        </tr>
        <tr>
            <td style="width: 348px">&nbsp;</td>
            <td style="width: 408px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
         </form>
</asp:Content>
