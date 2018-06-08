<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="test1.aspx.cs" Inherits="page_test1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:TextBox ID="txtdate" class="form-control"  runat="server" Height="41px" Width="438px" TextMode="Date" OnTextChanged="txtdate_TextChanged"></asp:TextBox>
    <asp:label runat="server" text="Label" ID="lbltest"></asp:label>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </asp:Content>

