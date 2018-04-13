<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="Schedule_register.aspx.cs" Inherits="page_Schedule_register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
        <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    <body>
        <center>  <P1>ลงตารางปฏิบัติงาน</P1> </center>

       <table class="table table-condensed">
 
            <tr class="active">
      <td class="active" style="width: 230px">
         วันปฏิบัติงาน</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txttelhomeparent" class="form-control"  runat="server" Height="41px" Width="438px" TextMode="Date"></asp:TextBox>
      </td>
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 230px">
         เวลาเริ่มการปฏิบัติงาน</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="TextBox1" class="form-control"  runat="server" Height="41px" Width="438px" TextMode="Time"></asp:TextBox>
      </td>
        
  </tr>
           
              <tr class="active">
      <td class="active" style="width: 230px">
         เวลาเลิกการปฏิบัติงาน</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="TextBox2" class="form-control"  runat="server" Height="41px" Width="438px" TextMode="Time"></asp:TextBox>
      </td>
        
  </tr>
             <tr class="active">
      <td class="active" style="width: 230px">
         หมายเหตุ</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtremark" class="form-control"  runat="server" Height="52px" Width="441px" TextMode="MultiLine"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <k2><asp:Button ID="btnsubmit" runat="server" class="btn btn-default" Text="ลงตารางการปฏิบัติงาน" ></asp:Button></k2>  
      </td>
        
        
  </tr>
    </table>






    </body>
</asp:Content>

