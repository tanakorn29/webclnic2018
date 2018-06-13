<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="schedule_work.aspx.cs" Inherits="schedule_work" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
      <link rel="stylesheet" href="../css/jquery.schedule.css">
    <link rel="stylesheet" href="../css/jquery.schedule-demo.css">
 
    <body>
        <center>  <P1>ตารางคำขอทำงานแทน <asp:Label ID="lbldoctor" runat="server" Text="-"></asp:Label></P1> 
      
        </center>
          <center>        <asp:GridView ID="GridView1" runat="server" Height="120px" Width="784px" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="swd_id">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="swd_id" HeaderText="swd_id" SortExpression="swd_id" InsertVisible="False" ReadOnly="True" />
                        <asp:BoundField DataField="swd_day_work" HeaderText="swd_day_work" SortExpression="swd_day_work" />
                        <asp:BoundField DataField="swd_start_time" HeaderText="swd_start_time" SortExpression="swd_start_time" />
                        <asp:BoundField DataField="swd_end_time" HeaderText="swd_end_time" SortExpression="swd_end_time" />
                        <asp:BoundField DataField="room_id" HeaderText="room_id" SortExpression="room_id" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="
select swd_id,swd_day_work,swd_start_time,swd_end_time,room_id  from schedule_work_doctor inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id where swd_status_room = 4 AND schedule_work_doctor.swd_emp_work_place =@emp_work_place ">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lbldoctor" Name="emp_work_place" PropertyName="Text" />
                    </SelectParameters>
                </asp:SqlDataSource>    </center> 
        <center>  <P1>จัดการข้อมูลตารางปฏิบัติงาน</P1> </center>
           <table style="width: 100%;">
             <tr>
                <td style="height: 20px">ลำดับตารางงาน</td>
                <td style="height: 20px"> 
                
                    <asp:Label ID="lblswdid" runat="server"></asp:Label>
                
                </td>
        
            </tr>

                        

                     <tr>
                <td style="height: 20px" colspan="2">
                  <center>  <asp:Button ID="btnsubmit" runat="server" Text="ลงเวลาปฏิบัติงาน" class="btn btn-primary" Height="49px" Width="247px" OnClick="btnsubmit_Click"/></center></td>
          
            </tr>
        </table>
        </body>
</asp:Content>

