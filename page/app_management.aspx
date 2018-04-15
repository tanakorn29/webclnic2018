<%@ Page Title="" Language="C#" MasterPageFile="~/page5.master" AutoEventWireup="true" CodeFile="app_management.aspx.cs" Inherits="page_app_management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    
<body>
  <center>  
      <P1>จัดการข้อมูลการนัดหมายคนไข้</P1> </center>
        <table class="table table-condensed">
  
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
          สถานะการนัดหมาย&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1"  class="dropdown-item" runat="server" Height="42px" Width="193px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
              <asp:ListItem Value="9">กรุณาเลือกสถานะการนัดหมาย</asp:ListItem>
              <asp:ListItem Value="2">แพทย์ขอเลื่อนนัด</asp:ListItem>
              <asp:ListItem Value="3">คนไข้ขอเลื่อนนัด</asp:ListItem>
          </asp:DropDownList>
      
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; จำนวนคนไข้ที่มีการเลื่อนนัดหมาย&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="lblnumber" runat="server"></asp:Label>
&nbsp; คน</td>
        
  </tr>
             <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
          <asp:Label ID="lbloutput" runat="server" Text="Label"></asp:Label>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <k2><asp:Button ID="btnapp" runat="server" class="btn btn-default" Text="ส่งใบนัดหมายให้แพทย์อนุมัติ" OnClick="btnapp_Click" ></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </k2>
      </td>
        
        
  </tr>
    </table> <br />

</body>
</asp:Content>

