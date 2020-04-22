<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="AddTeacher.aspx.cs" Inherits="AddTeacher" %>

<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <div>
    <center>
<table width="80%">

<tr><td colspan="2"><br /></td></tr>
<tr><td colspan="2" class="tabhea"><h2>Teacher Details</h2></td></tr>
<tr><td colspan="2"><br /></td></tr>
</table>
<table width="60%">
    <tr>
    <td width="20%" class="lab">
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        </td><td width="40%">
            <asp:TextBox ID="TextBox1"  class="w3-input" required runat="server" 
                CssClass="tx"></asp:TextBox>
        </td>
    </tr>
    <tr><td colspan="2"><br /></td></tr>
    <tr>
    <td class="lab">
        <asp:Label ID="Label3" runat="server" Text="Qualification"></asp:Label>
        </td><td>
            <asp:TextBox ID="TextBox2" class="w3-input" required runat="server" 
                CssClass="tx"></asp:TextBox>
        </td>
    </tr>
    <tr><td colspan="2"><br /></td></tr>
    <tr>
    <td class="lab">
        <asp:Label ID="Label4" runat="server" Text="Mobile Number"></asp:Label>
        </td><td>
            <asp:TextBox ID="TextBox3" class="w3-input" required runat="server" 
                CssClass="tx"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TextBox3" ErrorMessage="Invalid Mobile Number" 
                Font-Size="X-Small" ForeColor="Red" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr><td colspan="2"><br /></td></tr>
    <tr>
    <td class="lab">
        <asp:Label ID="Label5" runat="server" Text="E-Mail ID"></asp:Label>
        </td><td>
            <asp:TextBox ID="TextBox4" class="w3-input" required runat="server" 
                CssClass="tx"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="TextBox4" ErrorMessage="Invalid E-Mail ID" 
                Font-Size="X-Small" ForeColor="Red" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr><td colspan="2"><br /></td></tr>
    <tr><td colspan="2" align="center">
        <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
            CssClass="btn" /></td></tr>
 <tr><td colspan="2"><br /></td></tr>
</table>
</center>
</div>

</asp:Content>