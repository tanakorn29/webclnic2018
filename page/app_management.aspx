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
          &nbsp;จำนวนคนไข้ที่มีการเลื่อนนัดหมาย&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="lblnumber" runat="server"></asp:Label>
&nbsp; คน</td>
        
  </tr>
             <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
          <center><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" EmptyDataText="ค้นหาไม่เจอ" Height="158px" Visible="False" Width="872px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="app_id">
              <Columns>
                  <asp:CommandField ShowSelectButton="True" />
                  <asp:BoundField DataField="app_id" HeaderText="รหัสอ้างอิงการนัดหมาย" SortExpression="app_id" InsertVisible="False" ReadOnly="True" />
                  <asp:BoundField DataField="app_remark" HeaderText="หมายเหตุ" SortExpression="app_remark" />
                  <asp:BoundField DataField="emp_doc_name" HeaderText="แพทย์ผู้ทำการรักษา" SortExpression="emp_doc_name" />
                  <asp:BoundField DataField="opd_name" HeaderText="ชื่อคนไข้" SortExpression="opd_name" />
                  
   
                  
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
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select appointment.app_id,appointment.app_date,appointment.app_time,appointment.app_remark,employee_doctor.emp_doc_name,opd.opd_name,appointment.status_approve from ((appointment inner join opd On opd.opd_id= appointment.opd_id) inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id) where  (appointment.status_approve = 3) AND appointment.status_app = 1">
          </asp:SqlDataSource></center>
      </td>
         </tr>

              <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
      <center><P1>ตารางงานแพทย์</P1></center> 
      </td>
        
        
  </tr>

             <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <center>   <asp:GridView ID="GridView2" runat="server" EmptyDataText="ไม่มีแพทย์ปฏิบัติงาน" Width="771px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                     <Columns>
                         <asp:BoundField DataField="swd_date_work" HeaderText="swd_date_work" SortExpression="swd_date_work" DataFormatString="{0:yyyy-MM-dd}" />
                         <asp:BoundField DataField="swd_day_work" HeaderText="swd_day_work" SortExpression="swd_day_work" />
                         <asp:BoundField DataField="swd_start_time" HeaderText="swd_start_time" SortExpression="swd_start_time" />
                         <asp:BoundField DataField="room_id" HeaderText="room_id" SortExpression="room_id" />
                         <asp:BoundField DataField="swd_note" HeaderText="swd_note" SortExpression="swd_note" />
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
AND employee_doctor.emp_doc_name = @emp_doc_name ">
                         <SelectParameters>
                             <asp:ControlParameter ControlID="txtdoctor" Name="emp_doc_name" PropertyName="Text" />
                         </SelectParameters>
          </asp:SqlDataSource></center> 
      </td>
        
        
  </tr>
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
        <k2><asp:TextBox ID="txtdate" class="form-control" runat="server" Width="229px" Enabled="False" TextMode="Date"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 70px; height: 50px;">
        <k2>เวลาการนัดหมาย</k2>
      </td>
          <td class="active" style="width: 230px; height: 50px;">
              <k2>
            <asp:DropDownList ID="DropDownList1" class="btn btn-secondary dropdown-toggle" runat="server" Height="116px" Width="254px">
                <asp:ListItem>08.30</asp:ListItem>
                <asp:ListItem>09.30</asp:ListItem>
                <asp:ListItem>10.30</asp:ListItem>
                <asp:ListItem>11.15</asp:ListItem>
                <asp:ListItem>13.30</asp:ListItem>
                <asp:ListItem>14.30</asp:ListItem>
                <asp:ListItem>15.10</asp:ListItem>
            </asp:DropDownList>
              </k2>
      </td>
        
        
  </tr>
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
        <k2><asp:Button ID="btnapp" runat="server" class="btn btn-default" Text="นัดหมาย" OnClick="btnapp_Click" ></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Button1" runat="server" class="btn btn-default"  Height="41px" Text="ยกเลิกการนัดหมาย" Width="171px" OnClick="Button1_Click" />
          </k2>
      </td>
        
        
  </tr>
    </table> <br />

</body>
</asp:Content>

