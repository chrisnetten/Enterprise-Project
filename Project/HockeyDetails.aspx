<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HockeyDetails.aspx.cs" Inherits="Project.HockeyDetails" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

       <div class="container">
           <div class="row">
                   <h1>Hockey Game Details</h1>
                   <div class="form-group">
                       <label class="control-label" for="TeamOneTextBox">Team One</label>
                       <asp:TextBox runat="server" CssClass="form-control" ID="TeamOneTextBox" placeholder="Team One Name" required="true"></asp:TextBox>
                   </div>
                    <div class="form-group">
                       <label class="control-label" for="TeamTwoTextBox">Team Two</label>
                       <asp:TextBox runat="server" CssClass="form-control" ID="TeamTwoTextBox" placeholder="Team Two Name" required="true"></asp:TextBox>
                   </div>
                    <div class="form-group">
                       <label class="control-label" for="ScoreOneTextBox">Score One</label>
                       <asp:TextBox runat="server" CssClass="form-control" ID="ScoreOneTextBox" placeholder="Team One Score" required="true"></asp:TextBox>
                   </div>
                    <div class="form-group">
                       <label class="control-label" for="ScoreTwoTextBox">Score Two</label>
                       <asp:TextBox runat="server" CssClass="form-control" ID="ScoreTwoTextBox" placeholder="Team Two Score" required="true"></asp:TextBox>
                        <div class="form-group">
                       <label class="control-label" for="AsistsOneTextBox">Score One</label>
                       <asp:TextBox runat="server" CssClass="form-control" ID="AsistsOneTextBox" placeholder="Team One Asists" required="true"></asp:TextBox>
                   </div>
                    <div class="form-group">
                       <label class="control-label" for="AsistsTwoTextBox">Score Two</label>
                       <asp:TextBox runat="server" CssClass="form-control" ID="AsistsTwoTextBox" placeholder="Team Two Asists" required="true"></asp:TextBox>
                   </div>

                        <div class="text-right">
                            <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click"/>
                           <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SaveButton_Click"/>

                        </div>
</div>
               </div>


       </div>       
    </asp:Content>