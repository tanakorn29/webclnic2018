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
                    <td>ชื่อแพทย์ </td>
                     <td colspan="2">  <asp:TextBox ID="txtdocname" class="form-control"  runat="server" Height="42px" Width="256px" Enabled="False" OnTextChanged="txtdocname_TextChanged"></asp:TextBox></td>
                 </tr>
              <tr>
                        <td>เลือกวันที่ปฏิบัติงาน</td>
                <td>
                               <asp:TextBox ID="txtdate" class="form-control"  runat="server" Height="41px" Width="233px" TextMode="Date"></asp:TextBox>
      
                              
      
                </td>
                            <td> <asp:Button ID="Button1" runat="server" Text="เลือก" class="btn btn-primary" Height="49px" Width="227px" OnClick="btnselect_Click" /></td>
                 </tr>

               <tr>
                    <td colspan="3"><center>วันที่ปฏิบัติงาน&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    <asp:TextBox ID="txtswdwork" class="form-control"  runat="server" AutoPostBack="True" Height="41px" Width="226px" Enabled="False" OnTextChanged="txtswdwork_TextChanged" ></asp:TextBox>  </center></td>

                   </tr>
         
        </table>
  <center><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Vertical" Height="136px" Width="714px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="swd_id">
      <AlternatingRowStyle BackColor="#DCDCDC" />
      <Columns>
          <asp:CommandField ShowSelectButton="True" />
          <asp:BoundField DataField="swd_id" HeaderText="รหัสอ้างอิงการปฏิบัติงาน" SortExpression="swd_id" InsertVisible="False" ReadOnly="True" />
          <asp:BoundField DataField="swd_day_work" HeaderText="วัน" SortExpression="swd_day_work" />
          <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มปฏิบัติงาน" SortExpression="swd_start_time" />
          <asp:BoundField DataField="swd_end_time" HeaderText="เวลาเลิกงาน" SortExpression="swd_end_time" />
          <asp:BoundField DataField="room_id" HeaderText="ห้องตรวจ" SortExpression="room_id" />
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
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select swd_id,swd_day_work,swd_start_time,swd_end_time,room_id  from schedule_work_doctor inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id where swd_status_room = 1 AND employee_doctor.emp_doc_name =@emp_doc_name AND swd_date_work = @swd_date_work">
          <SelectParameters>
              <asp:ControlParameter ControlID="txtdocname" Name="emp_doc_name" PropertyName="Text" />
              <asp:ControlParameter ControlID="txtswdwork" Name="swd_date_work" PropertyName="Text" />
          </SelectParameters>
      </asp:SqlDataSource>
    </center>  
          <table style="width: 100%;">
        
            <tr class="active">
      <td class="active" style="width: 230px">
          รหัสอ้างอิงตารางปฏิบัติงาน</td>
        <td class="active" style="width: 342px">

   
            <asp:TextBox ID="txtswd" class="form-control"  runat="server" Enabled="False" Height="26px" Width="188px"></asp:TextBox>
                 &nbsp;
                 <asp:Button ID="btnsummit" runat="server" Height="39px" class="btn btn-primary" Text="เลื่อนวันปฏิบัติงาน" Width="146px" OnClick="btnsummit_Click" />
                </td>
        
  </tr>
         
        </table>
     

</body>
</asp:Content>

