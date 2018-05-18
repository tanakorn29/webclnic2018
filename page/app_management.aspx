<%@ Page Title="" Language="C#" MasterPageFile="~/page5.master" AutoEventWireup="true" CodeFile="app_management.aspx.cs" Inherits="page_app_management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    
<body>
  <center>  
      <P1>จัดการข้อมูลการนัดหมายคนไข้</P1> </center>
        <table class="table table-condensed">
  
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
          สถานะการนัดหมาย&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1"  class="dropdown-item" runat="server" Height="42px" Width="193px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
              <asp:ListItem Value="9">กรุณาเลือกสถานะการนัดหมาย</asp:ListItem>
              <asp:ListItem Value="3">แพทย์ขอเลื่อนนัด</asp:ListItem>
              <asp:ListItem Value="4">คนไข้ขอเลื่อนนัด</asp:ListItem>
          </asp:DropDownList>
      
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; จำนวนคนไข้ที่มีการเลื่อนนัดหมาย&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="lblnumber" runat="server"></asp:Label>
&nbsp; คน</td>
        
  </tr>
             <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" EmptyDataText="ค้นหาไม่เจอ" Height="158px" Visible="False" Width="872px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="app_id">
              <Columns>
                  <asp:CommandField ShowSelectButton="True" />
                  <asp:BoundField DataField="app_id" HeaderText="รหัสอ้างอิงการนัด" SortExpression="app_id" InsertVisible="False" ReadOnly="True" />
                  <asp:BoundField DataField="app_date" HeaderText="วันที่นัด" SortExpression="app_date" DataFormatString="{0:yyyy-MM-dd}" HtmlEncode="False" />
                  <asp:BoundField DataField="app_time" HeaderText="เวลานัด" SortExpression="app_time" />
                  <asp:BoundField DataField="app_remark" HeaderText="หมายเหตุ" SortExpression="app_remark" />
                  <asp:BoundField DataField="emp_doc_name" HeaderText="ชื่อแพทย์ที่เข้าพบ" SortExpression="emp_doc_name" />
                  <asp:BoundField DataField="opd_name" HeaderText="ชื่อคนไข้" SortExpression="opd_name" />
                  
   
                  
              </Columns>
              <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
              <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
              <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
              <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
              <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
              <SortedAscendingCellStyle BackColor="#FFF1D4" />
              <SortedAscendingHeaderStyle BackColor="#B95C30" />
              <SortedDescendingCellStyle BackColor="#F1E5CE" />
              <SortedDescendingHeaderStyle BackColor="#93451F" />
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select appointment.app_id,appointment.app_date,appointment.app_time,appointment.app_remark,employee_doctor.emp_doc_name,opd.opd_name,appointment.status_approve from ((appointment inner join opd On opd.opd_id= appointment.opd_id) inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id) where  (appointment.status_approve = @status_approve) AND appointment.status_app = 1">
              <SelectParameters>
                  <asp:ControlParameter ControlID="DropDownList1" Name="status_approve" PropertyName="SelectedValue" Type="Int32" />
              </SelectParameters>
          </asp:SqlDataSource>
      </td>
         </tr>
              <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
      <center><P1>ข้อมูลการนัดหมายคนไข้</P1></center> 
      </td>
        
        
  </tr>
             <tr class="active">
      <td class="active" style="width: 70px">
        <k2>เลขที่อ้างอิงการนัดหมาย </k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtnum" class="form-control" runat="server" Width="229px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 70px">
        <k2>วันที่นัดหมาย </k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtdate" class="form-control" runat="server" Width="229px" Enabled="False" TextMode="Date"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 70px; height: 50px;">
        <k2>เวลาการนัดหมาย</k2>
      </td>
          <td class="active" style="width: 230px; height: 50px;">
        <k2><asp:TextBox ID="txttime" class="form-control" runat="server" Width="231px" Enabled="False" TextMode="Time"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 70px">
        <k2>หมายเหตุ</k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtremark" class="form-control" runat="server" Width="457px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
              <tr class="active">
      <td class="active" style="width: 70px">
        <k2>ชื่อแพทย์ผู้เข้าพบ </k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtdoctor" class="form-control" runat="server" Width="457px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 70px">
        <k2>ชื่อคนไข้ </k2>
      </td>
          <td class="active" style="width: 230px">
        <k2><asp:TextBox ID="txtopd" class="form-control" runat="server" Width="457px" Enabled="False"></asp:TextBox> </k2>
      </td>
        
        
  </tr>
  
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <k2><asp:Button ID="btnapp" runat="server" class="btn btn-default" Text="อนุมัติใบนัดหมาย" OnClick="btnapp_Click" ></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Button1" runat="server" class="btn btn-default"  Height="41px" Text="ยกเลิกการนัดหมาย" Width="171px" OnClick="Button1_Click" />
          </k2>
      </td>
        
        
  </tr>
    </table> <br />

</body>
</asp:Content>

