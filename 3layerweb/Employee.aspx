<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="_3layerweb.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="h1header" runat="server">
    EMPLOYEE DATA ENTRY
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="h2header" runat="server">
    Sign out
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="h3header" runat="server">
     <form id="form1" runat="server">
    <table style="width: 93%; height: 270px;">
    <tr>
        <td style="height: 46px; width: 184px">EMPID</td>
        <td style="height: 46px; width: 369px">
            <asp:TextBox ID="txtid" runat="server" Width="202px"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
            
        </td>
        <td style="height: 46px">
            <asp:Label ID="lblout1" runat="server" Text="_______!!!!"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="height: 38px; width: 184px">NAME</td>
        <td style="height: 38px; width: 369px">
            <asp:TextBox ID="txtname" runat="server" Width="202px"></asp:TextBox>
        </td>
        <td style="height: 38px"></td>
    </tr>
    <tr>
        <td style="width: 184px; height: 37px">CELL</td>
        <td style="width: 369px; height: 37px">
            <asp:TextBox ID="txtcell" runat="server" Width="202px"></asp:TextBox>
        </td>
        <td style="height: 37px"></td>
    </tr>
    <tr>
        <td style="width: 184px; height: 23px">ADDRESS</td>
        <td style="width: 369px; height: 23px">
            <asp:TextBox ID="txtadrs" runat="server" Width="202px"></asp:TextBox>
        </td>
        <td style="height: 23px"></td>
    </tr>
    <tr>
        <td style="width: 184px; height: 55px;">&nbsp;</td>
        <td style="width: 369px; height: 55px;">
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" Height="33px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
        </td>
        <td style="height: 55px">
            <asp:Button ID="Button8" runat="server" Text="Refresh Grid" OnClick="Button8_Click1" />
        </td>
    </tr>
    <tr>
        <td style="width: 184px; height: 34px;"></td>
        <td style="width: 369px; height: 34px;">
            <asp:Label ID="lblout" runat="server"></asp:Label>
        </td>
        <td style="height: 34px">
            <asp:Button ID="Button5" runat="server" Text="Product" Width="82px" OnClick="Button5_Click1" />
            <asp:Button ID="Button6" runat="server" Text="Customer" OnClick="Button6_Click" />
            <asp:Button ID="Button7" runat="server" Text="Supplier" OnClick="Button7_Click" />
        </td>
    </tr>
    <tr>
        <td style="width: 184px; height: 33px;"></td>
        <td style="width: 369px; height: 33px;">
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            </asp:GridView>
        </td>
        <td style="height: 33px">&nbsp;</td>
    </tr>
</table>
         </form>
  
   
    </asp:Content>

 <asp:Content ID="Content4" ContentPlaceHolderID="h4header" runat="server">
          <script src="Scripts/jquery.validate.js">

     </script>
    <script type="text/javascript">
           
        $('input[name="<%=Button1.UniqueID%>"]').click(function () {
            $("#form1").validate({
                rules: {
                    <% =txtid.UniqueID%>: "required",
                    <%=txtname.UniqueID%>: "required",
                    <% =txtcell.UniqueID%>: "required",
                    <%=txtadrs.UniqueID%>: "required",
                   
                },
                messages: {
                    <% =txtid.UniqueID%>: "please enter your id",
                    <%=txtname.UniqueID%>: "Please enter your name",
                    <% =txtcell.UniqueID%>: "please enter your number",
                    <%=txtadrs.UniqueID%>: "please enter your address"
                }
            })
        });

             $('input[name="<%=Button2.UniqueID%>"]').click(function () {
            $("#form1").validate({
                rules: {
                    <% =txtid.UniqueID%>: "required",
                    <%=txtname.UniqueID%>: "required",
                    <% =txtcell.UniqueID%>: "required",
                    <%=txtadrs.UniqueID%>: "required",
                   
                },
                messages: {
                    <% =txtid.UniqueID%>: "please enter your id",
                    <%=txtname.UniqueID%>: "Please enter your name",
                    <% =txtcell.UniqueID%>: "please enter your number",
                    <%=txtadrs.UniqueID%>: "please enter your address"
                }
            })
             });
        
        $('input[name="<%=Button3.UniqueID%>"]').click(function () {
            $("#form1").validate().currentForm="";
            $("#form1").validate({
                rules: {

                    <% =txtid.UniqueID%>: "required",
                  
                   
                },
                messages: {
                    <% =txtid.UniqueID%>: "please enter your id"
                 
                }
            })
            });
        $('input[name="<%=Button4.UniqueID%>"]').click(function () {
            $("#form1").validate().currentForm="";
            $("#form1").validate({
                rules: {
                    <% =txtid.UniqueID%>: "required",
                  
                   
                },
                messages: {
                    <% =txtid.UniqueID%>: "please enter your id"
                 
                }
            })
          });


    </script>

     </asp:Content>
  