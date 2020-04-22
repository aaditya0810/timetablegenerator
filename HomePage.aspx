<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html lang="en">
<head>
  <title>Time Table Generator</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <link rel="stylesheet" type="text/css" href="css/design.css">
  </head>

<body id="myPage" data-spy="scroll" data-target=".navbar" data-offset="60">
    <form runat="server">
<nav class="navbar navbar-default navbar-fixed-top">
  <div class="container">
    
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span> 
      </button>
      <a class="navbar-brand" href="#">Time Table Generator</a>
    </div>
    
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav navbar-right">
        <li><a href="#about">ABOUT</a></li>
       
		    <li><a href="#admin">ADMIN</a></li>
      </ul>
    </div>
  
  </div>
  </nav>

<div class="jumbotron text-center">
  <center>
      <asp:Image ID="Image1" runat="server" ImageUrl="~/timetable.jpg" /></center>
  
</div>

<!-- Container (About Section) -->
<div id="about" class="container-fluid">
  <div class="row">
    <div class="col-sm-8">
      <h2>About Time-Table Generator</h2>
      <h4>Time Table Generator System</h4>
      <p style="font-size:110%;">Time Table Generator used by admin.Admin can add teacher 
          details.</p>
        <p style="font-size:110%;">System generates time table automatically based on data 
            entered by admin.</p>
        <p style="font-size:110%;">&nbsp;</p>
    </div>
    
  </div>
</div>

<div class="container-fluid bg-grey">
  <div class="row">
      <div class="col-sm-4"><p><strong>VISION:</strong></p></th><td> Automatic Time Table 
          Generator, our software allows users to generate time table for newly occurring 
          changes in less time, with less effort and with more efficiency. It will allow 
          users to work on and view time tables in different platforms and view different 
          information simultaneously.</p>
</div>
  </div>
</div>
    
<!-- Container (student section) -->

        <!-- Container (Visitor Section) -->

<!-- Container (parent section) -->

        <div id="parent" class="container-fluid text-center">
        </div>

        <!-- Container (Faculty section) -->
    
<!-- Container (admin section) -->
    <div id="admin" class="container-admin text-left">
        <div class="row">
            <div class="col-sm-8">
                <h2>About ADMIN </h2>
                <p>
                    Hey there! i'm your superman.<br>
                    Always to the rescue.<br>
                    *Well, most of the times :P*
            </div>
            <div id="faculty" class="container-faculty text-left">
                <div class="row">
                    <div class="col-sm-4">
                        <span class="form"></span>
                        <table width="60%">
                        <tr><td width="30%"><label for="fname">Username</label></td><td width="30%"> <asp:TextBox ID="TextBox11" required runat="server" placeholder="Admin ID"></asp:TextBox></td></tr>
                       <tr><td colspan="2"><br /></td></tr>
                       <tr><td width="30%"><label for="lname">Password</label></td><td width="30%"> <asp:TextBox ID="TextBox12" required TextMode="Password" runat="server" placeholder="Admin Password"></asp:TextBox></td></tr>
                       <tr><td colspan="2"><br /></td></tr>
                        
                       <tr><td colspan="2"align="center"> <asp:Button ID="Button5" class="btn btn-danger" runat="server" Text="Login" OnClick="Button5_Click" /></td></tr>
                       
                   </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
      <div id="div1" style="text-align:right;background:#283442;color:White;padding-right:50px">
   Time Table Generator
     
      </div>
    </form>
</body>
</html>