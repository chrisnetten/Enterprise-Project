<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navbar.ascx.cs" Inherits="Project.User_Controls.Navbar" %>
<nav class="navbar navbar-inverse" role="navigation">
    <div class="container-fluid">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="Default.aspx"><i class="fa fa-graduation-cap  fa-lg"></i>Netten Game Tracker</a>
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right">
                <li id="Basketball" runat="server"><a href="BasketballDetails.aspx"><i class="fa fa-home fa-lg"></i> Basketball</a></li>
                <li id="Hockey" runat="server"><a href="HockeyDetails.aspx"><i class="fa fa-leanpub fa-lg"></i> Hockey</a></li>
                <li id="Soccer" runat="server"><a href="SoccerDetails.aspx"><i class="fa fa-book fa-lg"></i> Soccer</a></li>
                <li id="Paintball" runat="server"><a href="PaintballDetails.aspx"><i class="fa fa-puzzle-piece fa-lg"></i>Paintball</a></li>
                                <li id="Li1" runat="server"><a href="Login.aspx"><i class="fa fa-home fa-lg"></i>Login</a></li>

                                <li id="Li2" runat="server"><a href="Register.aspx"><i class="fa fa-home fa-lg"></i>Register</a></li>

            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container-fluid -->
</nav>