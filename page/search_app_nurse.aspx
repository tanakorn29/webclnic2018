<%@ Page Title="" Language="C#" MasterPageFile="~/page5.master" AutoEventWireup="true" CodeFile="search_app_nurse.aspx.cs" Inherits="page_search_app_nurse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

           <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    
<body>
  <center>  <P1>ค้นหาข้อมูลการนัดหมาย</P1> </center>
            <table class="table table-condensed">
     <tr class="active">
             <td class="active" style="width: 230px">
          &nbsp;กรอกชื่อคนไข้&nbsp;&nbsp;&nbsp;
          </td>
        
      <td class="active" style="width: 230px" colspan="2">
          <asp:TextBox ID="txtname" class="form-control" runat="server" Width="333px" AutoPostBack="True" OnTextChanged="txtname_TextChanged"></asp:TextBox> 
          </td>
        
  </tr>
                  <tr class="active">
        
      <td class="active" style="width: 230px" colspan="2">
          <center>  <P1>ชื่อคนไข้ &nbsp;&nbsp;&nbsp;  <asp:Label ID="lblname" runat="server"></asp:Label></P1> </center>
          </td>
        
  </tr>
            
             <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
          <center>
<asp:GridView ID="GridView1" runat="server" Height="171px" Width="781px" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataSourceID="SqlDataSource1" EmptyDataText="ไม่มีข้อมูล" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="opd_name" HeaderText="ชื่อคนไข้" SortExpression="opd_name" />
        <asp:BoundField DataField="app_date" HeaderText="วันที่นัดหมาย" SortExpression="app_date" DataFormatString="{0:yyyy-MM-dd}" />
        <asp:BoundField DataField="app_time" HeaderText="เวลานัดหมาย" SortExpression="app_time" />
        <asp:BoundField DataField="app_remark" HeaderText="หมายเหตุ" SortExpression="app_remark" />
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

              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="SELECT opd.opd_name, appointment.app_date, appointment.app_time, appointment.app_remark FROM appointment INNER JOIN employee_doctor ON employee_doctor.emp_doc_id = appointment.emp_doc_id INNER JOIN opd ON appointment.opd_id = opd.opd_id WHERE opd.opd_name = @opd_name AND appointment.status_app = 1" >
                  <SelectParameters>
                      <asp:ControlParameter ControlID="lblname" DefaultValue="" Name="opd_name" PropertyName="Text"  Type="String" />
                  </SelectParameters>
              </asp:SqlDataSource>

          </center>
      </td>
         </tr>

 
    </table> <br />
</body>







</asp:Content>

