<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="appointment_doctor.aspx.cs" Inherits="page_appointment_doctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    
<body>
  <center>  <P1>ตารางนัดหมายคนไข้  ของ <asp:Label ID="lblnamedoc" runat="server"></asp:Label></P1> </center>
<center>    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="135px" Width="733px" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="opd_name" HeaderText="ชื่อคนไข้" SortExpression="opd_name" />
            <asp:BoundField DataField="app_date" HeaderText="วันที่นัดหมาย" SortExpression="app_date" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="app_time" HeaderText="เวลา" SortExpression="app_time" />
            <asp:BoundField DataField="app_remark" HeaderText="หมายเหตุ" SortExpression="app_remark" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select opd.opd_name,app_date,app_time,app_remark from appointment
inner join employee_doctor on employee_doctor.emp_doc_id = appointment.emp_doc_id
inner join opd on appointment.opd_id = opd.opd_id
where employee_doctor.emp_doc_name = @emp_doc_name">
        <SelectParameters>
            <asp:ControlParameter ControlID="lblnamedoc" Name="emp_doc_name" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource> </center>
</body>
</asp:Content>

