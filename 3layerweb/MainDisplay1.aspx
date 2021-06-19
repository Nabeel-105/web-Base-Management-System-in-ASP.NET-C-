<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="MainDisplay1.aspx.cs" Inherits="_3layerweb.MainDisplay1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="h1header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="h2header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="h3header" runat="server">
    <form id="form6" runat="server">
    <table class="w-100">
    <tr>
        <td style="width: 331px">&nbsp;</td>
        <td style="width: 453px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Larger" ForeColor="Red" style="" Text="3tier WEB PROJECT"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 331px; height: 120px;">
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Admin Signup" Width="144px" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Customer Signup" Width="163px" />
        </td>
        <td style="width: 453px; height: 120px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="UserName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </td>
        <td style="height: 120px"></td>
    </tr>
    <tr>
        <td style="width: 331px; height: 91px;">
            <asp:Button ID="Button5" runat="server" Text="Supplier Signup" Width="152px" OnClick="Button5_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="EMPLOYEE Signup" Width="156px" />
        </td>
        <td style="width: 453px; height: 91px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
        </td>
        <td style="height: 91px">
            <asp:Label ID="lblout" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 331px; height: 91px;">&nbsp;</td>
        <td style="width: 453px; height: 91px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click1" Text="Login" Width="166px" />
        </td>
        <td style="height: 91px">&nbsp;</td>
    </tr>
</table>
        </form>

</asp:Content>
