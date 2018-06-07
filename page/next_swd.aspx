<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="next_swd.aspx.cs" Inherits="next_swd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../../css/style.css">
      <center>  <P1>จัดการข้อมูลเลื่อนปฏิบัติงาน</P1></center>
      <table class="table table-condensed">
               <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
               <center> <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Vertical" Height="114px" Width="864px">
                   <AlternatingRowStyle BackColor="#CCCCCC" />
                   <Columns>
                       <asp:BoundField DataField="swd_month_work" HeaderText="เดือน" SortExpression="swd_month_work" />
                       <asp:BoundField DataField="swd_day_work" HeaderText="วัน" SortExpression="swd_day_work" />
                       <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มปฏิบัติงาน" SortExpression="swd_start_time" />
                       <asp:BoundField DataField="swd_end_time" HeaderText="เวลาเลิกปฏิบัติงาน" SortExpression="swd_end_time" />
                       <asp:BoundField DataField="swd_note" HeaderText="หมายเหตุ" SortExpression="swd_note" />
                       <asp:BoundField DataField="room_id" HeaderText="ห้องตรวจ" SortExpression="room_id" />
                   </Columns>
                   <FooterStyle BackColor="#CCCCCC" />
                   <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                   <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                   <SortedAscendingCellStyle BackColor="#F1F1F1" />
                   <SortedAscendingHeaderStyle BackColor="#808080" />
                   <SortedDescendingCellStyle BackColor="#CAC9C9" />
                   <SortedDescendingHeaderStyle BackColor="#383838" />
                   </asp:GridView> 
                   <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select swd_month_work,swd_day_work,swd_start_time,swd_end_time,swd_note,emp_ru_id,
 swd_status,room_id from schedule_work_doctor
where  swd_day_work = @swd_day_work AND swd_status = 'เปิด' AND swd_status_room = 0">
                       <SelectParameters>
                           <asp:ControlParameter ControlID="DropDownList2" Name="swd_day_work" PropertyName="SelectedValue" />
                       </SelectParameters>
                   </asp:SqlDataSource>
               </center></td>

        
  </tr>
        
            <tr class="active">
      <td class="active" style="width: 230px">
          เวลา</td>
        <td class="active" style="width: 342px">

   
            <asp:DropDownList ID="DropDownList1" class="dropdown-item" runat="server" Height="38px" Width="318px">
                <asp:ListItem>กรุณาเลือกเวลา</asp:ListItem>
                <asp:ListItem>08.30</asp:ListItem>
                <asp:ListItem>13.00</asp:ListItem>
            </asp:DropDownList>
           
                </td>
        
  </tr>
           <tr class="active">
      <td class="active" style="width: 230px">
         วัน</td>
        <td class="active" style="width: 342px">
            
                       <asp:DropDownList ID="DropDownList2" class="dropdown-item" runat="server" Height="28px" Width="315px" AutoPostBack="True">
                           <asp:ListItem>กรุณาเลือกวัน</asp:ListItem>
                           <asp:ListItem>จันทร์</asp:ListItem>
                           <asp:ListItem>อังคาร</asp:ListItem>
                           <asp:ListItem>พุธ</asp:ListItem>
                           <asp:ListItem>พฤหัสบดี</asp:ListItem>
                           <asp:ListItem>ศุกร์</asp:ListItem>
                           <asp:ListItem>เสาร์</asp:ListItem>
                           <asp:ListItem>อาทิตย์</asp:ListItem>
                       </asp:DropDownList>


            


               </td>
        
  </tr>
      
          
           <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
         <center>
           
                <asp:Button ID="btnsummit" runat="server" Height="39px" class="btn btn-primary" Text="เลื่อนวันปฏิบัติงาน" Width="146px" OnClick="btnsummit_Click"/>
           
                </center> 
               </td>
     
        
  </tr>
    </table>

</asp:Content>

