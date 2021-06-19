<%@ Page Title="" Language="C#" MasterPageFile="~/Product.Master" AutoEventWireup="true" CodeBehind="Prodmaster.aspx.cs" Inherits="_3layerweb.Prodmaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="h1header" runat="server">
    PRODUCT DATA ENTRY 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="h2header" runat="server">
    Sign out
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="h3header" runat="server">
     <form id="form3" runat="server">
     <table class="auto-style1">
            <tr>
                <td class="auto-style4" style="width: 174px">
                    <asp:Label ID="Label2" runat="server" Text="Product id"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtpid" runat="server" Width="168px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
                </td>
                <td class="auto-style6" style="width: 515px"></td>
            </tr>
            <tr>
                <td class="auto-style7" style="width: 174px">
                    <asp:Label ID="Label3" runat="server" Text="Title"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txttitle" runat="server" Width="168px"></asp:TextBox>
                </td>
                <td class="auto-style9" style="width: 515px"></td>
            </tr>
            <tr>
                <td class="auto-style7" style="width: 174px">
                    <asp:Label ID="Label4" runat="server" Text="Prize"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtprize" runat="server" Width="168px"></asp:TextBox>
                </td>
                <td class="auto-style9" style="width: 515px"></td>
            </tr>
            <tr>
                <td class="auto-style7" style="width: 174px">
                    <asp:Label ID="Label5" runat="server" Text="Stock"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtstock" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td class="auto-style9" style="width: 515px"></td>
            </tr>
            <tr>
                <td class="auto-style10" style="width: 174px">
                    <asp:Label ID="Label6" runat="server" Text="Expiry"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtexpiry" runat="server" Width="167px" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style12" style="width: 515px"></td>
            </tr>
            <tr>
                <td class="auto-style7" style="width: 174px">
                    <asp:Label ID="Label7" runat="server" Text="Manufacturor"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtmft" runat="server" Height="22px" Width="166px"></asp:TextBox>
                </td>
                <td class="auto-style9" style="width: 515px">
                    <asp:Button ID="Button8" runat="server" Text="Refresh Grid" OnClick="Button8_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="width: 174px"></td>
                <td class="auto-style8">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Insert" />
                    <asp:Button ID="Button3" runat="server" Height="26px" OnClick="Button3_Click" Text="Update" />
                    <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
                </td>
                <td class="auto-style9" style="width: 515px">
                    <asp:Button ID="Button5" runat="server" Text="Employee" OnClick="Button5_Click" />
                    <asp:Button ID="Button6" runat="server" Text="Customer" OnClick="Button6_Click" />
                    <asp:Button ID="button11" runat="server" Text="Suppplier" OnClick="button11_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style13" style="width: 174px"></td>
                <td class="auto-style14">
                    <asp:Label ID="lblout" runat="server" Text="___________!!!!"></asp:Label>
                </td>
                <td class="auto-style15" style="width: 515px"></td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 174px">&nbsp;</td>
                <td class="auto-style3">
                    <asp:GridView ID="GridView1" runat="server" Width="445px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    </asp:GridView>
                </td>
                <td style="width: 515px">&nbsp;</td>
            </tr>
        </table>
         </form>
</asp:Content>
 <asp:Content ID="Content4" ContentPlaceHolderID="h4header" runat="server">
          <script src="Scripts/jquery.validate.js">

     </script>
    <script type="text/javascript">
           
        $('input[name="<%=Button2.UniqueID%>"]').click(function () {
            $("#form3").validate({
                rules: {
                    <% =txtpid.UniqueID%>: "required",
                    <%=txttitle.UniqueID%>: "required",
                    <% =txtprize.UniqueID%>: "required",
                    <%=txtstock.UniqueID%>: "required",
                    <%=txtexpiry.UniqueID%>: "required",
                    <%=txtmft.UniqueID%>: "required",
                   
                },
                messages: {
                     <% =txtpid.UniqueID%>: "please enter your id",
                    <%=txttitle.UniqueID%>: "Please enter your name",
                    <% =txtprize.UniqueID%>: "Please enter your price",
                    <%=txtstock.UniqueID%>: "Please enter your stock",
                    <%=txtexpiry.UniqueID%>: "Please enter your expiry",
                    <%=txtmft.UniqueID%>: "Please enter your manufacture name"
                  
                }
            })
        });

             $('input[name="<%=Button3.UniqueID%>"]').click(function () {
            $("#form3").validate({
                rules: {
                    <% =txtpid.UniqueID%>: "required",
                    <%=txttitle.UniqueID%>: "required",
                    <% =txtprize.UniqueID%>: "required",
                    <%=txtstock.UniqueID%>: "required",
                    <%=txtexpiry.UniqueID%>: "required",
                    <%=txtmft.UniqueID%>: "required",
                   
                },
                messages: {
                     <% =txtpid.UniqueID%>: "please enter your id",
                    <%=txttitle.UniqueID%>: "Please enter your name",
                    <% =txtprize.UniqueID%>: "Please enter your price",
                    <%=txtstock.UniqueID%>: "Please enter your stock",
                    <%=txtexpiry.UniqueID%>: "Please enter your expiry",
                    <%=txtmft.UniqueID%>: "Please enter your manufacture name"
                }
            })
             });
        
        $('input[name="<%=Button4.UniqueID%>"]').click(function () {
            $("#form3").validate().currentForm="";
            $("#form3").validate({
                rules: {

                    <% =txtpid.UniqueID%>: "required",
                  
                   
                },
                messages: {
                    <% =txtpid.UniqueID%>: "please enter your id"
                 
                }
            })
            });
        $('input[name="<%=Button1.UniqueID%>"]').click(function () {
            $("#form3").validate().currentForm="";
            $("#form3").validate({
                rules: {
                    <% =txtpid.UniqueID%>: "required",
                  
                   
                },
                messages: {
                    <% =txtpid.UniqueID%>: "please enter your id"
                 
                }
            })
          });


    </script>

     </asp:Content>