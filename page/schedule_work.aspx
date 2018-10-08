<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="schedule_work.aspx.cs" Inherits="schedule_work" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
      <link rel="stylesheet" href="../css/jquery.schedule.css">
    <link rel="stylesheet" href="../css/jquery.schedule-demo.css">
 
    <body>
        <center>  <P1>ตารางคำขอทำงานแทน <asp:Label ID="lbldoctor" runat="server" Text="-"></asp:Label></P1> 
    
        </center>

         <center><P1>รหัสแพทย์   <asp:Label ID="lbliddoc" runat="server" Text="-"></asp:Label></P1> </center>  
          <center>     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="swd_id" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" Height="127px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="943px">
              <Columns>
                  <asp:CommandField ShowSelectButton="True" />
                  <asp:BoundField DataField="swd_id" HeaderText="รหัสตารางงาน" InsertVisible="False" ReadOnly="True" SortExpression="swd_id" />
                  <asp:BoundField DataField="swd_day_work" HeaderText="วันปฏิบัติงาน" SortExpression="swd_day_work" />
                  <asp:BoundField DataField="swd_start_time" HeaderText="วันที่เริ่มปฏิบัติงาน" SortExpression="swd_start_time" />
                  <asp:BoundField DataField="swd_end_time" HeaderText="วันที่สิ้นสุดวันปฏิบัติงาน" SortExpression="swd_end_time" />
                  <asp:BoundField DataField="swd_emp_work_place" HeaderText="แพทย์ที่ขอทำงานแทน" SortExpression="swd_emp_work_place" />
                  <asp:BoundField DataField="room_id" HeaderText="ห้องตรวจ" SortExpression="room_id" />
              </Columns>
              <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
              <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
              <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
              <SortedAscendingCellStyle BackColor="#F7F7F7" />
              <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
              <SortedDescendingCellStyle BackColor="#E5E5E5" />
              <SortedDescendingHeaderStyle BackColor="#242121" />
              </asp:GridView>   
              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select swd_id,swd_day_work,swd_start_time,swd_end_time,swd_emp_work_place,room_id  from schedule_work_doctor inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id where swd_status_room = 4 AND schedule_work_doctor.emp_doc_id = @emp_doc_id">
                  <SelectParameters>
                      <asp:ControlParameter ControlID="lbliddoc" Name="emp_doc_id" PropertyName="Text" />
                  </SelectParameters>
              </asp:SqlDataSource>
        </center> 
        <center>  <P1>จัดการข้อมูลตารางปฏิบัติงาน</P1> </center>
           <table style="width: 100%;">
             <tr>
                <td style="height: 20px">ลำดับตารางงาน</td>
                <td style="height: 20px"> 
                
                    <asp:Label ID="lblswdid" runat="server"></asp:Label>
                
                </td>
        
            </tr>
                 <tr>
                <td style="height: 20px">แพทย์ที่ขอทำงานแทน</td>
                <td style="height: 20px"> 
                
                    <asp:Label ID="lbldoctorre" runat="server"></asp:Label>
                
                </td>
        
            </tr>
                        

                     <tr>
                <td style="height: 20px" colspan="2">
                  <center>  <asp:Button ID="btnsubmit" runat="server" Text="ลงเวลาปฏิบัติงาน" class="btn btn-primary" Height="49px" Width="247px" OnClick="btnsubmit_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Button ID="btncencel" runat="server" Text="ยกเลิกการทำงานแทน" class="btn btn-primary" Height="49px" Width="247px" OnClick="btncencel_Click"/></center></td>
          
            </tr>
        </table>
        </body>
</asp:Content>

