<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Create-Time-Table.aspx.cs" Inherits="Create_Time_Table" %>

<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>
<table width="80%">
<tr><td><br /></td></tr>
<tr><td class="tabhea">
   <h2> <asp:Label ID="Label1" runat="server" Text="Time Table"></asp:Label></h2></td></tr>
<tr><td><br /></td></tr>
</table>
<table width="90%">
<tr><td><br /></td></tr>
<tr><td>
   <h4> <asp:Label ID="Label3" runat="server" Text="Course A"></asp:Label></h4></td></tr>
   <tr><td>
   <hr /></td></tr>
<tr><td><br /></td></tr>
</table>
 </center>
    <asp:Table ID="Table1" runat="server" Width="90%" CssClass="table-condensed">
    <asp:TableHeaderRow>
    <asp:TableHeaderCell>Slot</asp:TableHeaderCell>
    <asp:TableHeaderCell>Timing</asp:TableHeaderCell>
    <asp:TableHeaderCell ColumnSpan="5" VerticalAlign="Middle">Days</asp:TableHeaderCell>
    </asp:TableHeaderRow>
   <asp:TableRow>
    <asp:TableCell ColumnSpan="2"></asp:TableCell>
    <asp:TableCell>Monday</asp:TableCell>
    <asp:TableCell>Tuesday</asp:TableCell>
        <asp:TableCell>Wednesday</asp:TableCell>
            <asp:TableCell>Thursday</asp:TableCell>
        <asp:TableCell>Friday</asp:TableCell>
   </asp:TableRow>
    <asp:TableRow CssClass="th">
    <asp:TableCell  VerticalAlign="Top">
        <asp:Table ID="Table2" runat="server">
        </asp:Table>
    </asp:TableCell>
   
    <asp:TableCell  VerticalAlign="Top">
        <asp:Table ID="Table3" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell  VerticalAlign="Top">
        <asp:Table ID="Table4" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell VerticalAlign="Top">
        <asp:Table ID="Table5" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell  VerticalAlign="Top">
        <asp:Table ID="Table6" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell  VerticalAlign="Top" >
        <asp:Table ID="Table7" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell  VerticalAlign="Top"  >
        <asp:Table ID="Table8" runat="server">
        </asp:Table>
    </asp:TableCell>
    </asp:TableRow>
    </asp:Table>
    <br />
    <center>
    <table width="90%">
<tr><td><br /></td></tr>
<tr><td>
   <h4> <asp:Label ID="Label2" runat="server" Text="Course B"></asp:Label></h4></td></tr>
   <tr><td><hr /></td></tr>
<tr><td><br /></td></tr>
</table>
</center>
    <!--===============================Course B===================================-->
   
    <center>
     <asp:Table ID="Table9" runat="server" Width="90%" CssClass="table-condensed">
    <asp:TableHeaderRow>
    <asp:TableHeaderCell>Slot</asp:TableHeaderCell>
    <asp:TableHeaderCell>Timing</asp:TableHeaderCell>
    <asp:TableHeaderCell ColumnSpan="5" VerticalAlign="Middle">Days</asp:TableHeaderCell>
    </asp:TableHeaderRow>
   <asp:TableRow>
    <asp:TableCell ColumnSpan="2"></asp:TableCell>
    <asp:TableCell>Monday</asp:TableCell>
    <asp:TableCell>Tuesday</asp:TableCell>
        <asp:TableCell>Wednesday</asp:TableCell>
            <asp:TableCell>Thursday</asp:TableCell>
        <asp:TableCell>Friday</asp:TableCell>
   </asp:TableRow>
    <asp:TableRow CssClass="th">
    <asp:TableCell  VerticalAlign="Top">
        <asp:Table ID="Table10" runat="server">
        </asp:Table>
    </asp:TableCell>
   
    <asp:TableCell VerticalAlign="Top" >
        <asp:Table ID="Table11" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell VerticalAlign="Top">
        <asp:Table ID="Table12" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell VerticalAlign="Top">
        <asp:Table ID="Table13" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell  VerticalAlign="Top"  >
        <asp:Table ID="Table14" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell  VerticalAlign="Top" >
        <asp:Table ID="Table15" runat="server">
        </asp:Table>
    </asp:TableCell>
     <asp:TableCell VerticalAlign="Top">
        <asp:Table ID="Table16" runat="server">
        </asp:Table>
    </asp:TableCell>
    </asp:TableRow>
    </asp:Table>
    <center><table width="80%">
    <tr><td><br /></td></tr>
    <tr><td align="center">
        <asp:Button ID="Button1" runat="server" Text="Export To Excel Course A" 
            CssClass="btn" onclick="Button1_Click"/> 
        <asp:Button ID="Button2" runat="server" Text="Export To Excel Course B" 
            CssClass="btn" onclick="Button2_Click" /></td></tr>
         <tr><td><br /></td></tr>
    </table></center>
   </center>
</asp:Content>