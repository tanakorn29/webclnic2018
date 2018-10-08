<%@ Page Title="" Language="C#" MasterPageFile="~/page2.master" AutoEventWireup="true" CodeFile="next_app.aspx.cs" Inherits="page_next_app" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    <center>  <P3>ยืนยันคำขอแพทย์ที่ขอเลื่อนนัดหมาย&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lbldate" runat="server"></asp:Label></P3> </center>


    <table style="width: 100%;">
       
        <tr>
            <td style="height: 20px">
             <center>    <asp:Button ID="btnnext" runat="server" Text="นัดหมายวันเดิม" class="btn btn-primary" Height="56px" Width="233px" OnClick="btnnext_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Button ID="Button1" runat="server" Text="เลื่อนนัดหมายตามแพทย์" class="btn btn-primary" Height="56px" Width="233px" OnClick="Button1_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Button ID="Button2" runat="server" Text="เลือกวันนัดหมายใหม่" class="btn btn-primary" Height="56px" Width="233px" OnClick="Button2_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </center></td>

           
        </tr>
    </table>


</asp:Content>

