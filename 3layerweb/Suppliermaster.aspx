<%@ Page Title="" Language="C#" MasterPageFile="~/Supplier.Master" AutoEventWireup="true" CodeBehind="Suppliermaster.aspx.cs" Inherits="_3layerweb.Suppliermaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="h1header" runat="server">
    SUPPLIER DATA ENTRY 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="h2header" runat="server">
    <p>
        sign out</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="h3header" runat="server">
     <form id="form5" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 300px; height: 49px">
                <asp:Label ID="Label1" runat="server" Text="Supplier id"></asp:Label>
            </td>
            <td style="height: 49px; width: 404px">
                <asp:TextBox ID="txtsid" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Search" />
            </td>
            <td style="height: 49px">
                <asp:Label ID="lblout1" runat="server" Text="!!!!!!!!!"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 300px; height: 50px">
                <asp:Label ID="Label2" runat="server" Text="Supplier Name"></asp:Label>
            </td>
            <td style="height: 50px; width: 404px">
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; </td>
            <td style="height: 50px"></td>
        </tr>
        <tr>
            <td style="width: 300px; height: 49px">
                <asp:Label ID="Label3" runat="server" Text="Cell"></asp:Label>
            </td>
            <td style="height: 49px; width: 404px">
                <asp:TextBox ID="txtcell" runat="server"></asp:TextBox>
            </td>
            <td style="height: 49px"></td>
        </tr>
        <tr>
            <td style="width: 300px; height: 52px">
                <asp:Label ID="Label4" runat="server" Text="Item Supply"></asp:Label>
            </td>
            <td style="height: 52px; width: 404px">
                <asp:TextBox ID="txtitemsupply" runat="server"></asp:TextBox>
            </td>
            <td style="height: 52px"></td>
        </tr>
        <tr>
            <td style="width: 300px; height: 49px">
                <asp:Label ID="Label5" runat="server" Text="Name Reciever"></asp:Label>
            </td>
            <td style="height: 49px; width: 404px">
                <asp:TextBox ID="txtnamereciver" runat="server"></asp:TextBox>
            </td>
            <td style="height: 49px"></td>
        </tr>
        <tr>
            <td style="width: 300px; height: 48px">
                <asp:Label ID="Label6" runat="server" Text="Total Amount"></asp:Label>
            </td>
            <td style="height: 48px; width: 404px">
                <asp:TextBox ID="txtamount" runat="server"></asp:TextBox>
            </td>
            <td style="height: 48px">
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Refresh Grid" />
            </td>
        </tr>
        <tr>
            <td style="width: 300px">&nbsp;</td>
            <td style="width: 404px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Employee" />
&nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Customer" />
&nbsp;
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Product" />
            </td>
        </tr>
        <tr>
            <td style="width: 300px">&nbsp;</td>
            <td style="width: 404px">
                <asp:Label ID="lblout" runat="server" Text="_______!!!"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 300px">&nbsp;</td>
            <td style="width: 404px">
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="396px">
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
         </form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="h4header" runat="server">
          <script src="Scripts/jquery.validate.js">

     </script>
    <script type="text/javascript">
           
        $('input[name="<%=Button1.UniqueID%>"]').click(function () {
            $("#form5").validate({
                rules: {
                    <% =txtsid.UniqueID%>: "required",
                    <%=txtname.UniqueID%>: "required",
                    <% =txtcell.UniqueID%>: "required",
                    <%=txtitemsupply.UniqueID%>: "required",
                    <%=txtnamereciver.UniqueID%>: "required",
                    <%=txtamount.UniqueID%>: "required",
                    
                   
                },
                messages: {
                     <% =txtsid.UniqueID%>: "please enter your id",
                    <%=txtname.UniqueID%>: "Please enter your name",
                    <% =txtcell.UniqueID%>: "Please enter your phone num",
                    <%=txtitemsupply.UniqueID%>: "Please enter your item supply",
                    <%=txtnamereciver.UniqueID%>: "Please enter your reciver name",
                    <%=txtamount.UniqueID%>: "Please enter your total amount"
                   
                  
                }
            })
        });

             $('input[name="<%=Button2.UniqueID%>"]').click(function () {
            $("#form5").validate({
              rules: {
                    <% =txtsid.UniqueID%>: "required",
                    <%=txtname.UniqueID%>: "required",
                    <% =txtcell.UniqueID%>: "required",
                    <%=txtitemsupply.UniqueID%>: "required",
                    <%=txtnamereciver.UniqueID%>: "required",
                    <%=txtamount.UniqueID%>: "required",
                    
                   
                },
                messages: {
                     <% =txtsid.UniqueID%>: "please enter your id",
                    <%=txtname.UniqueID%>: "Please enter your name",
                    <% =txtcell.UniqueID%>: "Please enter your phone num",
                    <%=txtitemsupply.UniqueID%>: "Please enter your item supply",
                    <%=txtnamereciver.UniqueID%>: "Please enter your reciver name",
                    <%=txtamount.UniqueID%>: "Please enter your total amount"
                     
                }
            })
             });
        
        $('input[name="<%=Button3.UniqueID%>"]').click(function () {
            $("#form5").validate().currentForm="";
            $("#form5").validate({
                rules: {

                    <% =txtsid.UniqueID%>: "required",
                  
                   
                },
                messages: {
                    <% =txtsid.UniqueID%>: "please enter your id"
                 
                }
            })
            });
        $('input[name="<%=Button8.UniqueID%>"]').click(function () {
            $("#form5").validate().currentForm="";
            $("#form5").validate({
                rules: {
                    <% =txtsid.UniqueID%>: "required",
                  
                   
                },
                messages: {
                    <% =txtsid.UniqueID%>: "please enter your id"
                 
                }
            })
          });


    </script>

     </asp:Content>