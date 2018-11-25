<%@ Page Title="" Language="C#" MasterPageFile="~/page6.master" AutoEventWireup="true" CodeFile="patient_appointment_nurse.aspx.cs" Inherits="page_patient_appointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
<body>
  <center>  <P1>เลื่อนการนัดหมาย</P1>
     
    </center>
      <table class="table table-condensed">
           <tr class="active">
                    <td class="active" style="width: 230px" colspan="2">
                <P1>     <center>ตารางงานแพทย์&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lbldoctor" runat="server" Text="-"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ความเชี่ยวชาญ&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblsp" runat="server" Text="-"></asp:Label></center>  

                      </td>


               </tr>
             <tr class="active">

             
                   <td class="active" style="width: 230px" colspan="2">
                 <center> <asp:GridView ID="GridView1" runat="server" EmptyDataText="ไม่มีแพทย์ปฏิบัติงาน" Width="771px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                     <Columns>
                         <asp:CommandField ShowSelectButton="True" />
                         <asp:BoundField DataField="emp_doc_name" HeaderText="ชื่อแพทย์" SortExpression="emp_doc_name" />
                         <asp:BoundField DataField="swd_day_work" HeaderText="วัน" SortExpression="swd_day_work" />
                         <asp:BoundField DataField="swd_date_work" HeaderText="วันที่" SortExpression="swd_date_work" DataFormatString="{0:yyyy-MM-dd}" />
                         <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มปฏิบัติงาน" SortExpression="swd_start_time" />
                         <asp:BoundField DataField="room_id" HeaderText="ห้องตรวจ" SortExpression="room_id" />
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
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select employee_doctor.emp_doc_name , 
schedule_work_doctor.swd_day_work,schedule_work_doctor.swd_date_work,
schedule_work_doctor.swd_start_time,
schedule_work_doctor.room_id,schedule_work_doctor.swd_note 
from schedule_work_doctor 
inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id 
inner join specialist on specialist.emp_doc_specialistid = employee_doctor.emp_doc_specialistid
where schedule_work_doctor.swd_status_room = 1 
AND specialist.emp_doc_specialist = @emp_doc_specialist  AND schedule_work_doctor.swd_status_checkwork = 0
">
                         <SelectParameters>
                             <asp:ControlParameter ControlID="lblsp" Name="emp_doc_specialist" PropertyName="Text" />
                         </SelectParameters>
                     </asp:SqlDataSource>
                       </center>     
                   
                   </td>
                 </tr>
           <tr class="active">
      <td class="active" style="width: 230px">
       แพทย์ผู้ทำการรักษา</td>
        <td class="active" style="width: 342px">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:TextBox ID="txtdocname" class="form-control"  runat="server" Height="41px" Width="242px" Enabled="False"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
         วันนัดหมาย</td>
        <td class="active" style="width: 342px">
            <asp:Label ID="lbldate" runat="server"></asp:Label>
            <asp:TextBox ID="txtdate" class="form-control"  runat="server" Height="41px" Width="242px" Enabled="False"></asp:TextBox>
      </td>
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 230px">
         เวลานัดหมาย</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txttimeapp" class="form-control"  runat="server" Height="41px" Width="242px" Enabled="False"></asp:TextBox>
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

