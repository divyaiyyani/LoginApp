<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoginApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<script runat="server">
  protected override void OnLoad(EventArgs e)
  {
      Response.Redirect("/Scripts/WebForms/WebForm1.aspx");
  }
</script>
</asp:Content>
