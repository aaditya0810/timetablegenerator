<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="CourseDetails.aspx.cs" Inherits="CourseDetails" %>
<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <style>
.tabhea
{
   background:#283442;
   font-family:@Yu Gothic UI Semibold;
   padding-left:20px;
   color:White;
    
}
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
</style>
</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <asp:Panel ID="Panel22" runat="server">
    
    <table width="80%">
<tr><td colspan="4"><br /></td></tr>
<tr><td colspan="4" class="tabhea">
   <h2> <asp:Label ID="Label1" runat="server" Text="Course Details"></asp:Label></h2></td></tr>
<tr><td><br /></td></tr>
</table>
<table width="80%">
<tr><td colspan="4"><br /></td></tr>
<tr><td colspan="2" class="lab" width="40%">
    <asp:Label ID="Label2" runat="server" Text="Course Name"></asp:Label></td>
    <td colspan="2" width="30%">
        <asp:TextBox ID="TextBox1" required runat="server" CssClass="tx" Width="80%"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="tx" Width="10%"></asp:TextBox>
    </td></tr>
    <tr><td colspan="4"><br /></td></tr>
    <tr><td class="lab" width="20%">
        <asp:Label ID="Label3" runat="server" Text="Number Of Lecture"></asp:Label></td>
        <td width="20%">
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="tx" Width="80%">
                <asp:ListItem>--Select--</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
            </asp:DropDownList>
        </td><td class="lab" width="20%">
                <asp:Label ID="Label4" runat="server" Text="Number Of Groups"></asp:Label></td>
        <td width="20%">
                    <asp:DropDownList ID="DropDownList4" runat="server" CssClass="tx" Width="80%">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                    </asp:DropDownList>
        </td></tr>
   <tr><td colspan="4"><br /></td></tr>
      <tr><td colspan="4" align="center">
          <asp:Button ID="Button1" runat="server" Text="Add Subject Details" 
              onclick="Button1_Click" CssClass="btn" /></td></tr>
         <tr><td colspan="4">
             <asp:HiddenField ID="h1" runat="server" />
             <asp:HiddenField ID="h2" runat="server" />
             
            
             <br /></td></tr>
</table>
</asp:Panel>
  <asp:Panel ID="Panel21" runat="server">
    <asp:Panel ID="Panel1" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab" width="40%">
        <asp:Label ID="Label5" runat="server" Text="Subject Name"></asp:Label></td>
        <td width="40%">
            <asp:TextBox ID="sub1" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label6" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach1" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label7" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type1" runat="server" CssClass="tx">
                              <asp:ListItem>Lecture</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
            
                <tr><td colspan="2"><br /></td></tr>
    </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab" width="40%">
        <asp:Label ID="Label8" runat="server" Text="Subject Name"></asp:Label></td>
        <td width="40%">
            <asp:TextBox ID="sub2" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label9" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach2" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label10" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type2" runat="server" CssClass="tx">
                              <asp:ListItem>Lecture</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
            
              
                <tr><td colspan="2"><br /></td></tr>
    </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel3" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label11" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub3" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label12" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach3" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label13" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type3" runat="server" CssClass="tx">
                              <asp:ListItem>Lecture</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
            
    </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel4" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label14" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub4" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label15" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach4" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label16" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type4" runat="server" CssClass="tx">
                              <asp:ListItem>Lecture</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel5" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label17" runat="server" Text="Subject Name"></asp:Label></td><td width="40%">
            <asp:TextBox ID="sub5" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab" >
        <asp:Label ID="Label18" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach5" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label19" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type5" runat="server" CssClass="tx">
                              <asp:ListItem>Lecture</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
      <asp:Panel ID="Panel6" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label20" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub6" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label21" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach6" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label22" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type6" runat="server" CssClass="tx">
                              <asp:ListItem>Lecture</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
      <asp:Panel ID="Panel7" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label23" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub7" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label24" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach7" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label25" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type7" runat="server" CssClass="tx">
                              <asp:ListItem>Lecture</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
      <asp:Panel ID="Panel8" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td  width="40%" class="lab">
        <asp:Label ID="Label26" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub8" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td>
        <asp:Label ID="Label27" runat="server" Text="Teacher Name" class="lab"></asp:Label></td><td>
                          <asp:DropDownList ID="teach8" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td>
        <asp:Label ID="Label28" runat="server" Text="Type" class="lab"></asp:Label></td><td>
                          <asp:DropDownList ID="type8" runat="server" CssClass="tx">
                              <asp:ListItem>Lecture</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
   
      <asp:Panel ID="Panel9" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label29" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub9" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label30" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach9" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label31" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type9" runat="server" CssClass="tx">
                              <asp:ListItem>Practical</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
      <asp:Panel ID="Panel10" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label32" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub10" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label33" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach10" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label34" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type10" runat="server" CssClass="tx">
                              <asp:ListItem>Practical</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
      <asp:Panel ID="Panel11" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label35" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub11" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label36" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach11" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label37" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type11" runat="server" CssClass="tx">
                              <asp:ListItem>Practical</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
      <asp:Panel ID="Panel12" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label38" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub12" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label39" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach12" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label40" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type12" runat="server" CssClass="tx">
                              <asp:ListItem>Practical</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
      <asp:Panel ID="Panel13" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab"  width="40%">
        <asp:Label ID="Label41" runat="server" Text="Subject Name"></asp:Label></td><td  width="40%">
            <asp:TextBox ID="sub13" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label42" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach13" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label43" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type13" runat="server" CssClass="tx">
                              <asp:ListItem>Practical</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
    <br />
      <asp:Panel ID="Panel14" runat="server">
    <table width="80%">
    <tr><td colspan="2"><br /></td></tr>
    <tr><td class="lab" width="40%">
        <asp:Label ID="Label44" runat="server" Text="Subject Name"></asp:Label></td><td width="40%">
            <asp:TextBox ID="sub14" required runat="server" CssClass="tx"></asp:TextBox></td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label45" runat="server" Text="Teacher Name"></asp:Label></td><td>
                          <asp:DropDownList ID="teach14" runat="server" CssClass="tx">
                              <asp:ListItem>--Select--</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
                  <tr><td class="lab">
        <asp:Label ID="Label46" runat="server" Text="Type"></asp:Label></td><td>
                          <asp:DropDownList ID="type14" runat="server" CssClass="tx">
                              <asp:ListItem>Practical</asp:ListItem>
                          </asp:DropDownList>
                      </td></tr>
              <tr><td colspan="2"><br /></td></tr>
             
    </table>
    </asp:Panel>
        
    <br />
     
   
      
  
    <table width="80%">
    <tr><td colspan="2" align="center">
        <asp:Button ID="Button2" runat="server" Text="Submit" 
            onclick="Button2_Click1" CssClass="btn" /></td></tr>
        <tr><td colspan="2"><br /></td></tr>
    </table>
    </asp:Panel>
    </center>
</asp:Content>