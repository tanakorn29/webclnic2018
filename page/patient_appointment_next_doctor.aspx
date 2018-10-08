<%@ Page Title="" Language="C#" MasterPageFile="~/page2.master" AutoEventWireup="true" CodeFile="patient_appointment_next_doctor.aspx.cs" Inherits="patient_appointment_next_doctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../../css/style.css">
<body>
  <center>  <P1>เลื่อนการนัดหมาย &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lbldateadd" runat="server"></asp:Label></P1>
      
     
    </center>
      <table class="table table-condensed">
           <tr class="active">
                    <td class="active" style="width: 230px" colspan="2">
                <P1>     <center>ตารางงานแพทย์&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lbldoctor" runat="server" Text="-"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ความเชี่ยวชาญ&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblspc" runat="server" Text="-"></asp:Label>
                        </center>  
               <!--       <center>  <P1>เลือกแพทย์ที่มารักษา &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2"  class="btn btn-secondary dropdown-toggle" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="emp_doc_name" DataValueField="emp_doc_name" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                          </asp:DropDownList>
                          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select emp_doc_name from employee_doctor  inner join specialist on specialist.emp_doc_specialistid = employee_doctor.emp_doc_specialistid where specialist.emp_doc_specialist =@emp_doc_specialist ORDER BY emp_doc_id DESC ">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="lblspc" Name="emp_doc_specialist" PropertyName="Text" />
                              </SelectParameters>
                          </asp:SqlDataSource>
                          &nbsp;</P1></center> -->
                      </td>


               </tr>
             <tr class="active">

             
                   <td class="active" style="width: 230px" colspan="2">
                 <center> <asp:GridView ID="GridView1" runat="server" EmptyDataText="ไม่มีแพทย์ปฏิบัติงาน" Width="771px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                     <Columns>
                         <asp:CommandField ShowSelectButton="True" />
                         <asp:BoundField DataField="swd_day_work" HeaderText="วันปฏิบัติงาน" SortExpression="swd_day_work" />
                         <asp:BoundField DataField="swd_date_work" HeaderText="วันที่ปฏิบัติงาน" SortExpression="swd_date_work" DataFormatString="{0:yyyy-MM-dd}" />
                         <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มงาน" SortExpression="swd_start_time" />
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
where schedule_work_doctor.swd_status_room = 1 
AND employee_doctor.emp_doc_name = @emp_doc_name AND schedule_work_doctor.swd_status_checkwork = 0 AND swd_note = 'เลื่อนปฏิบัติงาน' 
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
         วัน</td>
        <td class="active" style="width: 342px">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:TextBox ID="txtday" class="form-control"  runat="server" Height="41px" Width="242px" Enabled="False"></asp:TextBox>
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

