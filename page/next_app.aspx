<%@ Page Title="" Language="C#" MasterPageFile="~/page2.master" AutoEventWireup="true" CodeFile="next_app.aspx.cs" Inherits="page_next_app" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    <center>  <P3>ยืนยันคำขอแพทย์ที่ขอเลื่อนนัดหมาย</P3> </center>


    <table style="width: 100%;">
       
        <tr>
            <td style="height: 20px">
             <center>    <asp:Button ID="btnnext" runat="server" Text="ยืนยันนัดหมาย" class="btn btn-primary" Height="56px" Width="233px" OnClick="btnnext_Click" /> </center></td>

           
        </tr>
    </table>


</asp:Content>

