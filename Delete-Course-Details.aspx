<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Delete-Course-Details.aspx.cs" Inherits="Delete_Course_Details" %>

<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><table width="80%">
    <tr><td><br /></td></tr>
<tr>
<td class="tabhea">
  <h2>  <asp:Label ID="Label1" runat="server" Text="Delete Course Details"></asp:Label></h2></td>
</tr>
<tr><td><br /></td></tr>
<tr>
<td align="center">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Width="60%"   OnRowCommand="GridView1_RowCommand" CellPadding="3" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" 
        BorderWidth="1px" >
    <Columns>
                <asp:BoundField HeaderText="Course ID" DataField="cid"/>
                <asp:BoundField HeaderText="Course Name" DataField="cname"/>
                
<asp:TemplateField><ItemTemplate>

        <asp:LinkButton ID="yes" runat ="server" CommandArgument='<%#Eval("cid")%>' 
                 Text ="Delete" CommandName ="yes" ></asp:LinkButton>
      
</ItemTemplate>
</asp:TemplateField>
                
                </Columns>




        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#283442" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />



    </asp:GridView>
</td>
</tr>
</table>
</center>
</asp:Content>
