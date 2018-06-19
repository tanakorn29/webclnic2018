<%@ Page Language="C#" AutoEventWireup="true" CodeFile="date.aspx.cs" Inherits="date" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Date" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True"  OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <div>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
