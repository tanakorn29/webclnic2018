<%@ Page Title="" Language="C#" MasterPageFile="~/page.master" AutoEventWireup="true" CodeFile="login_opd.aspx.cs" Inherits="page_opd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
     <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    
<body>
  <div class="login-page">
  <div class="form">
      <k1>งานบริการคนไข้</k1>
       <asp:TextBox ID="txtusername" placeholder="ใส่ชื่อผู้ใช้" runat="server"></asp:TextBox>
       <asp:TextBox ID="txtpassword" placeholder="ใส่รหัสผ่าน" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Button ID="btnlogin" runat="server" class="btn btn-primary" Text="เข้าสู่ระบบ" BackColor="#660033"/>
      
     
        <p class="message">ในกรณีที่เป็นบุคคลากรสามารถตรวจสอบวันนัดมารักษาได้</p>    
  </div>
</div>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script type="text/javascript" src="../js/index.js"></script>
</asp:Content>

