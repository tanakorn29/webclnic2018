<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="Schedule_register.aspx.cs" Inherits="page_Schedule_register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
        <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    <body>
        <center>  <P1>ลงตารางปฏิบัติงาน</P1> </center>
       
        <table style="width: 100%;">
            <tr>
           
                   <td>วันที่ลงเวลาปฏิบัติงาน</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" class="dropdown-item" runat="server" AutoPostBack="True" Height="68px" Width="174px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
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
           
         
        </table>
    <center>  <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EmptyDataText="ยังไม่เปิดลงทะเบียน" Height="216px" Width="1105px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="swd_month_work" HeaderText="เดือน" SortExpression="swd_month_work" />
                <asp:BoundField DataField="swd_day_work" HeaderText="วัน" SortExpression="swd_day_work" />
                <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มปฏิบัติงาน" SortExpression="swd_start_time" />
                <asp:BoundField DataField="swd_end_time" HeaderText="เวลาเลิกปฏิบัติงาน" SortExpression="swd_end_time" />
                <asp:BoundField DataField="swd_note" HeaderText="หมายเหตุ" SortExpression="swd_note" />
                <asp:BoundField DataField="room_id" HeaderText="ห้องตรวจ" SortExpression="room_id" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView></center> 



        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select swd_month_work,swd_day_work,swd_start_time,swd_end_time,swd_note,emp_ru_id,
 swd_status,room_id from schedule_work_doctor
where  swd_day_work = @swd_day_work AND swd_status = 'เปิด' AND swd_status_room = 0">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList2" Name="swd_day_work" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
                <center>  <P1>จัดการข้อมูลตารางปฏิบัติงาน</P1> </center>
           <table style="width: 100%;">
        
                            <tr>
                <td style="height: 20px">เวลาปฏิบัติงาน</td>
                <td style="height: 20px"> 
                    <asp:DropDownList ID="DropDownList3"  class="dropdown-item" runat="server" Height="30px" Width="118px">
                        <asp:ListItem>กรุณาเลือกเวลาที่จะทำงาน</asp:ListItem>
                        <asp:ListItem Value="08.30">08.30</asp:ListItem>
                        <asp:ListItem>13.00</asp:ListItem>
                    </asp:DropDownList>
                </td>
        
            </tr>

               
                            <tr>
                <td style="height: 20px">วันปฏิบัติงาน</td>
                <td style="height: 20px"> 
                   <asp:TextBox ID="txtdate" class="form-control"  runat="server" Height="41px" Width="438px" Enabled="False" OnTextChanged="txtdate_TextChanged"></asp:TextBox>
                </td>
               

            </tr>

                     <tr>
                <td style="height: 20px" colspan="2">
                  <center>  <asp:Button ID="btnsubmit" runat="server" Text="ลงเวลาปฏิบัติงาน" class="btn btn-primary" Height="49px" Width="247px" OnClick="btnsubmit_Click" /></center></td>
          
            </tr>
        </table>

    </body>
</asp:Content>

