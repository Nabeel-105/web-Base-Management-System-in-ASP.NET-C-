<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.Master" AutoEventWireup="true" CodeBehind="Customermaster.aspx.cs" Inherits="_3layerweb.Customermaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="h1header" runat="server">
    CUSTOMER DATA ENTRY
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="h2header" runat="server">
    <p>
        sign out</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="h3header" runat="server">
     <form id="form2" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 278px; height: 47px">
                <asp:Label ID="Label1" runat="server" Text="Customer Id"></asp:Label>
            </td>
            <td style="height: 47px; width: 405px">
                <asp:TextBox ID="txtcid" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
            </td>
            <td style="height: 47px">
                <asp:Label ID="lblout1" runat="server" Text="!!!!!!!!!"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 278px; height: 47px">
                <asp:Label ID="Label2" runat="server" Text="Customer Name"></asp:Label>
            </td>
            <td style="height: 47px; width: 405px">
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            </td>
            <td style="height: 47px"></td>
        </tr>
        <tr>
            <td style="width: 278px; height: 54px">
                <asp:Label ID="Label3" runat="server" Text="Cell"></asp:Label>
            </td>
            <td style="height: 54px; width: 405px">
                <asp:TextBox ID="txtcell" runat="server"></asp:TextBox>
            </td>
            <td style="height: 54px"></td>
        </tr>
        <tr>
            <td style="width: 278px; height: 52px">
                <asp:Label ID="Label4" runat="server" Text="No of Item"></asp:Label>
            </td>
            <td style="height: 52px; width: 405px">
                <asp:TextBox ID="txtnoitem" runat="server"></asp:TextBox>
            </td>
            <td style="height: 52px"></td>
        </tr>
        <tr>
            <td style="width: 278px; height: 48px">
                <asp:Label ID="Label5" runat="server" Text="Total Bill"></asp:Label>
            </td>
            <td style="height: 48px; width: 405px">
                <asp:TextBox ID="txttbill" runat="server"></asp:TextBox>
            </td>
            <td style="height: 48px">
                <asp:Button ID="Button8" runat="server" Text="Refresh Grid" OnClick="Button8_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 278px">&nbsp;</td>
            <td style="width: 405px">
                <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
            </td>
            <td>
                <asp:Button ID="Button5" runat="server" Text="Employee" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button6" runat="server" Text="Product" OnClick="Button6_Click" />
&nbsp;&nbsp;
                <asp:Button ID="Button7" runat="server" Text="Supplier" OnClick="Button7_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 278px">&nbsp;</td>
            <td style="width: 405px">
                <asp:Label ID="lblout" runat="server" Text="_________!!!"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 278px">&nbsp;</td>
            <td style="width: 405px">
                <asp:GridView ID="GridView1" runat="server" Width="397px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
            $("#form2").validate({
                rules: {
                    <% =txtcid.UniqueID%>: "required",
                    <%=txtname.UniqueID%>: "required",
                    <% =txtcell.UniqueID%>: "required",
                    <%=txtnoitem.UniqueID%>: "required",
                    <%=txttbill.UniqueID%>: "required",
                    
                   
                },
                messages: {
                      <% =txtcid.UniqueID%>: "please enter your id",
                    <%=txtname.UniqueID%>: "Please enter your name",
                    <% =txtcell.UniqueID%>: "Please enter your phone num",
                    <%=txtnoitem.UniqueID%>: "Please enter no of item",
                    <%=txttbill.UniqueID%>: "Please enter your Bill Amount"
                   
                  
                }
            })
        });

             $('input[name="<%=Button2.UniqueID%>"]').click(function () {
            $("#form2").validate({
              rules: {
                    <% =txtcid.UniqueID%>: "required",
                    <%=txtname.UniqueID%>: "required",
                    <% =txtcell.UniqueID%>: "required",
                    <%=txtnoitem.UniqueID%>: "required",
                    <%=txttbill.UniqueID%>: "required",
                    
                   
                },
                messages: {
                      <% =txtcid.UniqueID%>: "please enter your id",
                    <%=txtname.UniqueID%>: "Please enter your name",
                    <% =txtcell.UniqueID%>: "Please enter your phone num",
                    <%=txtnoitem.UniqueID%>: "Please enter no of item",
                    <%=txttbill.UniqueID%>: "Please enter your Bill Amount"
                }
            })
             });
        
        $('input[name="<%=Button3.UniqueID%>"]').click(function () {
            $("#form2").validate().currentForm="";
            $("#form2").validate({
                rules: {

                    <% =txtcid.UniqueID%>: "required",
                  
                   
                },
                messages: {
                    <% =txtcid.UniqueID%>: "please enter your id"
                 
                }
            })
            });
        $('input[name="<%=Button4.UniqueID%>"]').click(function () {
            $("#form2").validate().currentForm="";
            $("#form2").validate({
                rules: {
                    <% =txtcid.UniqueID%>: "required",
                  
                   
                },
                messages: {
                    <% =txtcid.UniqueID%>: "please enter your id"
                 
                }
            })
          });


    </script>

     </asp:Content>