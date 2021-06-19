<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="EmployeeSignUp.aspx.cs" Inherits="_3layerweb.EmployeeSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="h1header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="h2header" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="h3header" runat="server">
    <form id="form1" runat="server">
    <table class="w-100">
        <tr>
            <td style="width: 288px">&nbsp;</td>
            <td style="width: 228px">&nbsp;</td>
            <td style="width: 205px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 288px">&nbsp;</td>
            <td style="width: 228px">Employeee SignUp Form</td>
            <td style="width: 205px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 288px">&nbsp;</td>
            <td style="width: 228px">&nbsp;</td>
            <td style="width: 205px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 288px">&nbsp;</td>
            <td style="width: 228px">
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            </td>
            <td style="width: 205px">
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 288px">&nbsp;</td>
            <td style="width: 228px">
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            </td>
            <td style="width: 205px">
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 25px; width: 288px"></td>
            <td style="height: 25px; width: 228px">
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            </td>
            <td style="height: 25px; width: 205px">
                <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            </td>
            <td style="height: 25px"></td>
        </tr>
        <tr>
            <td style="width: 288px">&nbsp;</td>
            <td style="width: 228px">
                <asp:Label ID="Label4" runat="server" Text="Corfim Password"></asp:Label>
            </td>
            <td style="width: 205px">
                <asp:TextBox ID="txtcpass" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblout" runat="server" Text="!!!!!!!!!!!!!!!!"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 288px">&nbsp;</td>
            <td style="width: 228px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Signup" />
            </td>
            <td style="width: 205px">
                <asp:Button ID="Button2" runat="server" Text="Login" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 288px">&nbsp;</td>
            <td style="width: 228px">&nbsp;</td>
            <td style="width: 205px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="h4header" runat="server">
</asp:Content>
