<%@ Page Title="" Language="C#" MasterPageFile="~/page4.master" AutoEventWireup="true" CodeFile="tre_his_stu.aspx.cs" Inherits="page_tre_his_stu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

    
     <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    
<body>
  <center>  
      <P1>ประวัติการรักษาของ <asp:Label ID="lblnamepop" runat="server"></asp:Label></P1> </center>




    <center> <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" Height="153px" Width="736px">
        <Columns>
            <asp:BoundField DataField="qdr_date" DataFormatString="{0:yyyy-MM-dd}" HeaderText="วันที่" SortExpression="qdr_date" />
            <asp:BoundField DataField="treatr_symptom" HeaderText="อาการ" SortExpression="treatr_symptom" />
            <asp:BoundField DataField="treatr_diagnose" HeaderText="โรค" SortExpression="treatr_diagnose" />
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select queue_diag_room.qdr_date,treatment_record.treatr_symptom,treatment_record.treatr_diagnose
from queue_diag_room
inner join opd on queue_diag_room.opd_id = opd.opd_id
inner join treatment_record on treatment_record.opd_id = opd.opd_id
where opd.opd_name = @opd_name ">
            <SelectParameters>
                <asp:ControlParameter ControlID="lblnamepop" Name="opd_name" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
    </center>
</body>

</asp:Content>

