<%@ Page Title="" Language="C#" MasterPageFile="~/page2.master" AutoEventWireup="true" CodeFile="patient_appointment_next.aspx.cs" Inherits="page_patient_appointment" %>

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
                <P1>     <center>ตารางงานแพทย์&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lbldoctor" runat="server" Text="-"></asp:Label></center>  

                      </td>


               </tr>
             <tr class="active">

             
                   <td class="active" style="width: 230px" colspan="2">
                 <center> <asp:GridView ID="GridView1" runat="server" EmptyDataText="ไม่มีแพทย์ปฏิบัติงาน" Width="771px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                     <Columns>
                         <asp:BoundField DataField="swd_day_work" HeaderText="วันปฏิบัติงาน" SortExpression="swd_day_work" />
                         <asp:BoundField DataField="swd_date_work" HeaderText="วันที่ปฏิบัติงาน" SortExpression="swd_date_work" DataFormatString="{0:yyyy-MM-dd}" />
                         <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มงาน" SortExpression="swd_start_time" />
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
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select employee_doctor.emp_doc_name , 
schedule_work_doctor.swd_day_work,schedule_work_doctor.swd_date_work,
schedule_work_doctor.swd_start_time,
schedule_work_doctor.room_id,schedule_work_doctor.swd_note 
from schedule_work_doctor 
inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id 
where schedule_work_doctor.swd_status_room = 1 
AND employee_doctor.emp_doc_name = @emp_doc_name 
">
                         <SelectParameters>
                             <asp:ControlParameter ControlID="lbldoctor" Name="emp_doc_name" PropertyName="Text" />
                         </SelectParameters>
                     </asp:SqlDataSource>
                       </center>     
                   
                   </td>
                 </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
         วันนัดหมาย</td>
        <td class="active" style="width: 342px">
            <asp:Label ID="lbldate" runat="server"></asp:Label>
            <asp:TextBox ID="txtdate" class="form-control"  runat="server" Height="41px" Width="242px" TextMode="Date"></asp:TextBox>
            <asp:Button ID="btnapp" runat="server" class="btn btn-default" Text="เลือก" OnClick="btnapp_Click" ></asp:Button>
      </td>
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 230px">
         เวลานัดหมาย</td>
        <td class="active" style="width: 342px">
            <asp:DropDownList ID="DropDownList1" class="btn btn-secondary dropdown-toggle" runat="server" Height="81px" Width="254px">
                <asp:ListItem>08.30</asp:ListItem>
                <asp:ListItem>09.30</asp:ListItem>
                <asp:ListItem>10.30</asp:ListItem>
                <asp:ListItem>11.15</asp:ListItem>
                <asp:ListItem>13.30</asp:ListItem>
                <asp:ListItem>14.30</asp:ListItem>
                <asp:ListItem>15.10</asp:ListItem>
            </asp:DropDownList>
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

