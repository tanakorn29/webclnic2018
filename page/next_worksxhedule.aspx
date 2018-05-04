<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="next_worksxhedule.aspx.cs" Inherits="page_next_worksxhedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
<body>
  <center>  <P1>เลื่อนการปฏิบัติงาน  </P1>
      &nbsp;</center>
         <table style="width: 100%;">
            <tr>
                <td style="height: 20px">ห้องตรวจ</td>
                <td style="height: 20px"> 
                    <asp:DropDownList ID="ddlroom" class="dropdown-item" runat="server" Height="63px" Width="238px" AutoPostBack="True" OnSelectedIndexChanged="ddlroom_SelectedIndexChanged">
                        <asp:ListItem>เลือกห้องตรวจ</asp:ListItem>
                        <asp:ListItem Value="1"></asp:ListItem>
                        <asp:ListItem Value="2"></asp:ListItem>
                        <asp:ListItem Value="3"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                   <td>วัน</td>
                <td>
                    <asp:DropDownList ID="ddlday" class="dropdown-item" runat="server" Height="68px" Width="174px" AutoPostBack="True" OnSelectedIndexChanged="ddlday_SelectedIndexChanged" >
                        <asp:ListItem>กรุณาเลือกวัน</asp:ListItem>
                        <asp:ListItem>monday</asp:ListItem>
                        <asp:ListItem>tuesday</asp:ListItem>
                        <asp:ListItem>wednesday</asp:ListItem>
                        <asp:ListItem>Thursday</asp:ListItem>
                        <asp:ListItem>Friday</asp:ListItem>
                        <asp:ListItem>saturday</asp:ListItem>
                        <asp:ListItem>sunday</asp:ListItem>
                    </asp:DropDownList>
                </td>
                  <td>เวลา</td>
                <td>
                    <asp:DropDownList ID="ddltime" class="dropdown-item" runat="server" Height="68px" Width="174px" AutoPostBack="True" OnSelectedIndexChanged="ddltime_SelectedIndexChanged" >

                        <asp:ListItem>8:30</asp:ListItem>
                        <asp:ListItem>13:00</asp:ListItem>
                     
                    </asp:DropDownList>
                </td>
            </tr>
             <tr>
                    <td>ชื่อแพทย์ </td>
                     <td>  <asp:TextBox ID="txtdocname" class="form-control"  runat="server" Height="42px" Width="256px" Enabled="False"></asp:TextBox></td>
                 </tr>
         
        </table>
  <center><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Vertical" Height="136px" Width="714px">
      <AlternatingRowStyle BackColor="#DCDCDC" />
      <Columns>
          <asp:BoundField DataField="emp_doc_name" HeaderText="ชื่อแพทย์" SortExpression="emp_doc_name" />
          <asp:BoundField DataField="swd_day_work" HeaderText="วัน" SortExpression="swd_day_work" />
          <asp:BoundField DataField="swd_start_time" HeaderText="เวลา" SortExpression="swd_start_time" />
          <asp:BoundField DataField="room_id" HeaderText="ห้องตรวจ" SortExpression="room_id" />
          <asp:BoundField DataField="swd_note" HeaderText="หมายเหตุ" SortExpression="swd_note" />
      </Columns>
      <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
      <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
      <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
      <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
      <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
      <SortedAscendingCellStyle BackColor="#F1F1F1" />
      <SortedAscendingHeaderStyle BackColor="#0000A9" />
      <SortedDescendingCellStyle BackColor="#CAC9C9" />
      <SortedDescendingHeaderStyle BackColor="#000065" />
      </asp:GridView>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select employee_doctor.emp_doc_name , 
schedule_work_doctor.swd_day_work,
schedule_work_doctor.swd_start_time,
schedule_work_doctor.room_id
,schedule_work_doctor.swd_note 
from schedule_work_doctor 
inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id
 where emp_doc_name =@emp_doc_name AND swd_status_room = 2">
          <SelectParameters>
              <asp:ControlParameter ControlID="txtdocname" Name="emp_doc_name" PropertyName="Text" />
          </SelectParameters>
      </asp:SqlDataSource>
    </center>  
      <center>  <P1>จัดการข้อมูลการเลื่อนการปฏิบัติงาน</P1> </center>
      <table class="table table-condensed">
  <tr class="active">
      <td class="active" style="width: 230px">
          ห้องตรวจ</td>
        <td class="active" style="width: 342px">
                    <asp:TextBox ID="txtroom" class="form-control"  runat="server" Height="42px" Width="256px" Enabled="False"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          เวลา</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txttime" class="form-control"  runat="server" Height="44px" Width="252px" Enabled="False"></asp:TextBox>
                </td>
        
  </tr>
           <tr class="active">
      <td class="active" style="width: 230px">
         วัน</td>
        <td class="active" style="width: 342px">
                       <asp:TextBox ID="txtday" class="form-control"  runat="server" Width="259px" Enabled="False" Height="48px"></asp:TextBox>
               </td>
        
  </tr>

          
           <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
          <asp:Button ID="btnsummit" runat="server" Height="39px" class="btn btn-primary" Text="เลื่อนวันปฏิบัติงาน" Width="249px" OnClick="btnsummit_Click" />
               </td>
     
        
  </tr>
    </table>

</body>
</asp:Content>

