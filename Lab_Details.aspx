<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Lab_Details.aspx.cs" Inherits="Lab_Details" %>

<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <center>
<table width="80%">

<tr><td colspan="2"><br /></td></tr>
<tr><td colspan="2" class="auto-style1"><h2>Lab Details</h2></td></tr>
<tr><td colspan="2"><br /></td></tr>
    <tr><td colspan="2" align="right" style="padding-right: 20px"><asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="X-Large" OnClick="LinkButton1_Click" CausesValidation="False">Clear Lab Details</asp:LinkButton></td></tr>
    <tr><td colspan="2"><br /></td></tr>
</table>
<table width="60%">
    <tr>
    <td width="20%" class="lab">
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        </td><td width="40%">
            <asp:TextBox ID="TextBox1"  class="w3-input"  runat="server" 
                CssClass="tx"></asp:TextBox>
           
        </td>
    </tr>
    <tr><td class="auto-style2"></td><td align="left" class="auto-style2">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    
    <tr><td colspan="2"><br /></td></tr>
    <tr><td colspan="2" align="center">
        <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
            CssClass="btn" /></td></tr>
 <tr><td colspan="2"><br /></td></tr>
</table>
        <asp:Panel ID="Panel1" runat="server">

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="60%">

                <Columns>
                <asp:BoundField HeaderText="Lab Name" DataField="name"/>
               
                </Columns>

                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />

            </asp:GridView>
        </asp:Panel>


</center>
</div>


</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style>

    .lab
    {
        font-size:large;
        font-family:Californian FB;
        padding-left:100px;
        
    }
    .tx {
  padding: 10px;
  border: none;
  border-bottom: solid 1px #c9c9c9;
  transition: border 0.3s;
  width:100%
}
.text:focus,
.text.focus {
  border-bottom: solid 1px #969696;
  width:100%
}
.btn {
  background: #0a9afa;
  background-image: -webkit-linear-gradient(top, #0a9afa, #166799);
  background-image: -moz-linear-gradient(top, #0a9afa, #166799);
  background-image: -ms-linear-gradient(top, #0a9afa, #166799);
  background-image: -o-linear-gradient(top, #0a9afa, #166799);
  background-image: linear-gradient(to bottom, #0a9afa, #166799);
  -webkit-border-radius: 6;
  -moz-border-radius: 6;
  border-radius: 6px;
  font-family: Arial;
  color: #ffffff;
  font-size: 24px;
  padding: 10px 20px 10px 20px;
  text-decoration: none;
}

.btn:hover {
  background: #3cb0fd;
  background-image: -webkit-linear-gradient(top, #3cb0fd, #3498db);
  background-image: -moz-linear-gradient(top, #3cb0fd, #3498db);
  background-image: -ms-linear-gradient(top, #3cb0fd, #3498db);
  background-image: -o-linear-gradient(top, #3cb0fd, #3498db);
  background-image: linear-gradient(to bottom, #3cb0fd, #3498db);
  text-decoration: none;
}
.tabhea
{
   background:#283442;
   font-family:@Yu Gothic UI Semibold;
   padding-left:20px;
   color:White;
    
}

.th {
    background-color: #f2f2f2;
}
    
    </style>
    <style type="text/css">
        .auto-style1 {
            background: #283442;
            font-family: @Yu Gothic UI Semibold;
            padding-left: 20px;
            color: White;
            height: 63px;
        }
        .auto-style2 {
            height: 20px;
        }
    </style>
</asp:Content>
