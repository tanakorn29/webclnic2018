<%@ Page Title="" Language="C#" MasterPageFile="~/page2.master" AutoEventWireup="true" CodeFile="appointment.aspx.cs" Inherits="page_appointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
<body>
  <center>  <P1>การนัดหมาย</P1> </center>
      <table class="table table-condensed">
     <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
         ข้อมูลการนัดหมาย</td>
   
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
         วันนัดหมาย</td>
        <td class="active" style="width: 342px">
          
            <asp:Label ID="lbldate" runat="server"></asp:Label>
          
      </td>
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 230px">
         เวลานัดหมาย</td>
        <td class="active" style="width: 342px">
            
            <asp:Label ID="lbltime" runat="server"></asp:Label>
            
      </td>
        
  </tr>
                <tr class="active">
      <td class="active" style="width: 230px">
         แพทย์ผู้ทำการรักษา</td>
        <td class="active" style="width: 342px">
            
            <asp:Label ID="lbldoctor" runat="server"></asp:Label>
            
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <k2><asp:Button ID="btnapp" runat="server" class="btn btn-default" Text="เลื่อนนัดหมาย" ></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnhistory" runat="server" class="btn btn-default" Text="ประวัติการนัดหมาย" ></asp:Button></k2>  
      </td>
        
        
  </tr>
    </table>

</body>
</asp:Content>

