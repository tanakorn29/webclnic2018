﻿<%@ Page Title="" Language="C#" MasterPageFile="~/page6.master" AutoEventWireup="true" CodeFile="app_management_opdnurse.aspx.cs" Inherits="page_app_management" %>

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
          &nbsp;จำนวนคนไข้ที่มีการเลื่อนนัดหมาย&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="lblnumber" runat="server"></asp:Label>
&nbsp; คน</td>
        
  </tr>
             <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
          <center><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" EmptyDataText="ค้นหาไม่เจอ" Height="158px" Visible="False" Width="872px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="app_id">
              <Columns>
                  <asp:CommandField ShowSelectButton="True" />
                  <asp:BoundField DataField="app_id" HeaderText="รหัสการนัดหมาย" SortExpression="app_id" InsertVisible="False" ReadOnly="True" />
                  <asp:BoundField DataField="app_date" HeaderText="วันที่นัดหมาย" SortExpression="app_date" DataFormatString="{0:yyyy-MM-dd}" />
                  <asp:BoundField DataField="app_time" HeaderText="เวลา" SortExpression="app_time" />
                  <asp:BoundField DataField="app_remark" HeaderText="หมายเหตุ" SortExpression="app_remark" />
                  
   
                  
                  <asp:BoundField DataField="emp_doc_name" HeaderText="ชื่อแพทย์" SortExpression="emp_doc_name" />
                  <asp:BoundField DataField="opd_name" HeaderText="คนไข้" SortExpression="opd_name" />
                  
   
                  
              </Columns>
              <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
              <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
              <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
              <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
              <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
              <SortedAscendingCellStyle BackColor="#FFF1D4" />
              <SortedAscendingHeaderStyle BackColor="#B95C30" />
              <SortedDescendingCellStyle BackColor="#F1E5CE" />
              <SortedDescendingHeaderStyle BackColor="#93451F" />
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select appointment.app_id,appointment.app_date,appointment.app_time,appointment.app_remark,employee_doctor.emp_doc_name,opd.opd_name,appointment.status_approve from ((appointment inner join opd On opd.opd_id= appointment.opd_id) inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id) where  (appointment.status_approve = 3) OR (appointment.status_approve = 6) AND appointment.status_app = 1">
          </asp:SqlDataSource></center>
      </td>
         </tr>

              <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
 <!--     <center><P1>ตารางงานแพทย์</P1></center> 
      </td>
        
        
  </tr>

             <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <center>   <asp:GridView ID="GridView2" runat="server" EmptyDataText="ไม่มีแพทย์ปฏิบัติงาน" Width="771px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                     <Columns>
                         <asp:CommandField ShowSelectButton="True" />
                         <asp:BoundField DataField="swd_date_work" HeaderText="เวลาปฏิบัติงาน" SortExpression="swd_date_work" DataFormatString="{0:yyyy-MM-dd}" />
                         <asp:BoundField DataField="swd_day_work" HeaderText="วัน" SortExpression="swd_day_work" />
                         <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มปฏิบัติงาน" SortExpression="swd_start_time" />
                         <asp:BoundField DataField="room_id" HeaderText="ห้องตรวจ" SortExpression="room_id" />
                         <asp:BoundField DataField="swd_note" HeaderText="หมายเหตุ" SortExpression="swd_note" />
                     </Columns>
                     <FooterStyle BackColor="White" ForeColor="#000066" />
                     <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                     <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                     <RowStyle ForeColor="#000066" />
                     <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                     <SortedAscendingCellStyle BackColor="#F1F1F1" />
                     <SortedAscendingHeaderStyle BackColor="#007DBB" />
                     <SortedDescendingCellStyle BackColor="#CAC9C9" />
                     <SortedDescendingHeaderStyle BackColor="#00547E" />
                     </asp:GridView> 
                     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select schedule_work_doctor.swd_date_work,
schedule_work_doctor.swd_day_work,
schedule_work_doctor.swd_start_time,
schedule_work_doctor.room_id,schedule_work_doctor.swd_note 
from schedule_work_doctor 
inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id 
where schedule_work_doctor.swd_status_room = 1 
AND employee_doctor.emp_doc_name = @emp_doc_name AND schedule_work_doctor.swd_status_checkwork = 0">
                         <SelectParameters>
                             <asp:ControlParameter ControlID="txtdoctor" Name="emp_doc_name" PropertyName="Text" />
                         </SelectParameters>
          </asp:SqlDataSource></center> 
      </td>
        
        
  </tr> -->
              <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
      <center><P1>ข้อมูลการนัดหมายคนไข้</P1></center> 
      </td>
        
        
  </tr>
             <tr class="active">
      <td class="active" style="width: 70px">
        <k2>เลขที่อ้างอิงการนัดหมาย </k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtnum" class="form-control" runat="server" Width="229px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
             <tr class="active">
     <td class="active" style="width: 70px">
        <k2>วันที่นัดหมาย </k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtday" class="form-control" runat="server" Width="229px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
   <!--           <tr class="active">
      <td class="active" style="width: 70px">
        <k2>วันที่นัดหมาย </k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtdate" class="form-control" runat="server" Width="229px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 70px; height: 50px;">
        <k2>เวลาการนัดหมาย</k2>
      </td>
          <td class="active" style="width: 230px; height: 50px;">
              <k2>
              <asp:TextBox ID="txttime" class="form-control" runat="server" Width="229px" Enabled="False"></asp:TextBox> 
              </k2>
      </td>
        
        
  </tr> -->
              <tr class="active">
      <td class="active" style="width: 70px">
        <k2>หมายเหตุ</k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtremark" class="form-control" runat="server" Width="457px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 70px">
        <k2>ชื่อแพทย์ผู้เข้าพบ </k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtdoctor" class="form-control" runat="server" Width="457px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 70px">
        <k2>ชื่อคนไข้ </k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtopd" class="form-control" runat="server" Width="457px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
  
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <k2><asp:Button ID="btnapp" runat="server" class="btn btn-default" Text="ส่งข้อมูลนัดหมาย" OnClick="btnapp_Click" ></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          </k2>
      </td>
        
        
  </tr>
    </table> <br />

</body>
</asp:Content>

