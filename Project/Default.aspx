<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project.Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
    <a href="BasketballDetails.aspx" CssClass="btn btn-success btn-sm">Add New Basketball Game</a>
    <asp:GridView runat="server" ID="BasketballGridView" CssClass="table table-bordered table-striped table-hover"
          >
  

    </asp:GridView>
        <a href="HockeyDetails.aspx" CssClass="btn btn-success btn-sm">Add New Hockey Game</a>

      <asp:GridView runat="server" ID="HockeyGridView" CssClass="table table-bordered table-striped table-hover">
        

    </asp:GridView>
            <a href="SoccerDetails.aspx" CssClass="btn btn-success btn-sm">Add New Soccer Game</a>

    <asp:GridView runat="server" ID="SoccerGridView" CssClass="table table-bordered table-striped table-hover">
        

    </asp:GridView>

            <a href="PaintballDetails.aspx" CssClass="btn btn-success btn-sm">Add New Paintball Game</a>

      <asp:GridView runat="server" ID="PaintballGridView" CssClass="table table-bordered table-striped table-hover">
        

    </asp:GridView>


</asp:Content>
