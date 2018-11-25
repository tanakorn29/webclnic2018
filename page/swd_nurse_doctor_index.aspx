<%@ Page Title="" Language="C#" MasterPageFile="~/page6.master" AutoEventWireup="true" CodeFile="swd_nurse_doctor_index.aspx.cs" Inherits="swd_nurse_doctor_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    
<body>
  <center>  <P1>ค้นหาตารางงานแพทย์</P1></center>
            <table class="table table-condensed">
     <tr class="active">
             <td class="active" style="width: 230px">
                 กรอกชื่อแพทย์
          </td>
        
      <td class="active" style="width: 230px" colspan="2">
          <asp:TextBox ID="txtname" class="form-control" runat="server" Width="333px" AutoPostBack="True" OnTextChanged="txtname_TextChanged"></asp:TextBox> 
          </td>
        
  </tr>
                  <tr class="active">
        
      <td class="active" style="width: 230px" colspan="2">
          <center>  <P1>ชื่อแพทย์ &nbsp;&nbsp;&nbsp;  <asp:Label ID="lblname" runat="server"></asp:Label></P1> </center>
          </td>
        
  </tr>
            
             <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
          <center>
<asp:GridView ID="GridView1" runat="server" Height="171px" Width="781px" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataSourceID="SqlDataSource1" EmptyDataText="ไม่มีข้อมูล" GridLines="None">
    <Columns>
        <asp:BoundField DataField="swd_day_work" HeaderText="วัน" SortExpression="swd_day_work" />
        <asp:BoundField DataField="swd_date_work" HeaderText="วันที่" SortExpression="swd_date_work" DataFormatString="{0:yyyy-MM-dd}" />
        <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มงาน" SortExpression="swd_start_time" />
        <asp:BoundField DataField="swd_end_time" HeaderText="เวลาเลิกงาน" SortExpression="swd_end_time" />
        <asp:BoundField DataField="room_id" HeaderText="ห้องตรวจ" SortExpression="room_id" />
    </Columns>
    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#594B9C" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#33276A" />
              </asp:GridView>

              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select swd_day_work,swd_date_work,swd_start_time,swd_end_time,room_id  
from schedule_work_doctor 
inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id 
where swd_status_room = 1 AND employee_doctor.emp_doc_name = @emp_doc_name " >
                  <SelectParameters>
                      <asp:ControlParameter ControlID="lblname" Name="emp_doc_name" PropertyName="Text" />
                  </SelectParameters>
              </asp:SqlDataSource>

          </center>
      </td>
         </tr>

 
    </table> <br />
</body>

</asp:Content>

