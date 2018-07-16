<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="show_timeadd.aspx.cs" Inherits="show_timeadd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    
<body>
  <center>  <P1>ข้อมูลการเข้าออกงานแพทย์  ของ <asp:Label ID="lblnamedoc" runat="server"></asp:Label></P1> </center>
<center>    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Height="135px" Width="733px" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="start_time" HeaderText="เวลาเข้างาน" SortExpression="start_time" />
            <asp:BoundField DataField="end_time" HeaderText="เวลาเลิกงาน" SortExpression="end_time" />
            <asp:BoundField DataField="date_work" HeaderText="วันที่ทำงาน" SortExpression="date_work" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="remark" HeaderText="สถานะ" SortExpression="remark" />
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
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select start_time,end_time,date_work,remark from time_attendance
inner join employee_doctor on time_attendance.emp_doc_id = employee_doctor.emp_doc_id
where employee_doctor.emp_doc_name = @emp_doc_name">
        <SelectParameters>
            <asp:ControlParameter ControlID="lblnamedoc" Name="emp_doc_name" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource> </center>
</body>









</asp:Content>

