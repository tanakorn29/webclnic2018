<%@ Page Title="" Language="C#" MasterPageFile="~/page2.master" AutoEventWireup="true" CodeFile="patient_appointment_next.aspx.cs" Inherits="page_patient_appointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
<body>
  <center>  <P1>เลื่อนการนัดหมาย</P1> </center>
      <table class="table table-condensed">
 
            <tr class="active">
      <td class="active" style="width: 230px">
         วันนัดหมาย</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtdate" class="form-control"  runat="server" Height="41px" Width="438px" TextMode="Date"></asp:TextBox>
      </td>
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 230px">
         เวลานัดหมาย</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txttime" class="form-control"  runat="server" Height="41px" Width="438px" TextMode="Time"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <k2><asp:Button ID="btnsubmit" runat="server" class="btn btn-default" Text="นัดหมาย" OnClick="btnsubmit_Click" ></asp:Button></k2>  
      </td>
        
        
  </tr>
    </table>

</body>
</asp:Content>

