<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="Schedule.aspx.cs" Inherits="page_Schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
      <link rel="stylesheet" href="../css/jquery.schedule.css">
    <link rel="stylesheet" href="../css/jquery.schedule-demo.css">
 
    <body>
  <center>  <P1>ตารางปฏิบัติงานแพทย์  <asp:Label ID="lbldoctor" runat="server" Text="-"></asp:Label></P1> 
      
        </center>
      <div class="row">
            <div class="col">
           <!--  <div id="schedule" class="jqs-demo mb-3"></div>  -->    
        <center>        <asp:GridView ID="GridView1" runat="server" Height="120px" Width="784px" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="swd_day_work" HeaderText="วัน" SortExpression="swd_day_work" />
                        <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มทำงาน" SortExpression="swd_start_time" />
                        <asp:BoundField DataField="swd_end_time" HeaderText="เวลาเลิกงาน" SortExpression="swd_end_time" />
                        <asp:BoundField DataField="room_id" HeaderText="ห้อง" SortExpression="room_id" />
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
select swd_day_work,swd_start_time,swd_end_time,room_id  from schedule_work_doctor inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id where swd_status_room = 1 AND employee_doctor.emp_doc_name =@emp_doc_name">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lbldoctor" Name="emp_doc_name" PropertyName="Text" />
                    </SelectParameters>
                </asp:SqlDataSource>    </center> 
            </div>
          <center>  <P1>ตารางทำงานแทนชั่วคราว</P1> 
      
        </center>


          <center><asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="swd_id" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Vertical" Height="87px" Width="752px">
              <AlternatingRowStyle BackColor="#CCCCCC" />
              <Columns>
                  <asp:BoundField DataField="swd_day_work" HeaderText="วัน" SortExpression="swd_day_work" />
                  <asp:BoundField DataField="swd_start_time" HeaderText="เวลาเริ่มปฏิบัติงาน" SortExpression="swd_start_time" />
                  <asp:BoundField DataField="swd_end_time" HeaderText="เวลาเลิกงาน" SortExpression="swd_end_time" />
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
              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connectionstring %>" SelectCommand="select swd_id,swd_day_work,swd_start_time,swd_end_time,room_id  from schedule_work_doctor inner join employee_doctor on employee_doctor.emp_doc_id = schedule_work_doctor.emp_doc_id where swd_status_room = 1 AND schedule_work_doctor.swd_emp_work_place =@emp_work_place ">
                  <SelectParameters>
                      <asp:ControlParameter ControlID="lbldoctor" Name="emp_work_place" PropertyName="Text" />
                  </SelectParameters>
              </asp:SqlDataSource>
            </center>
     <center>    <asp:Button ID="btnregister" runat="server" Text="เลื่อนวันและเวลาปฏิบัติงาน" BackColor="#000066" class="btn btn-primary" Height="45px" Width="203px" OnClick="btnregister_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    <asp:Button ID="btnworkswd" runat="server" Text="ทำงานแทน" BackColor="#000066" class="btn btn-primary" Height="45px" Width="203px" OnClick="btnworkswd_Click" Visible="False"/></center> 
        </div>
          <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="../js/jquery.schedule.js"></script>
        <script>

            //   $("#schedule").jqs();

            $.ajax({

                type: "POST",

                url: "Schedule.aspx/GetData",

                contentType: "application/json; charset=utf-8",

                dataType: "json",

                success: function (response) {

                    var names = response.d;


                    alert(names);

                  
                },

                failure: function (response) {

                    alert(response.d);

                }

            });

            $("#schedule").jqs(names/*{
                mode: "read",
                days: ["จันทร์", "อังคาร", "พุธ", "พฤหัส", "ศุกร์", "เสาร์", "อาทิตย์"],
                data: [

                   {
                    day: 0,
                    periods: [

                   //  [response.d]
                    ]
                }, {
                    day: 1,
                    periods: [
                     //   ["00:00", "08:30"]
                    ]
                }]
            }*/);
            // alert("อัพเดตแล้ว");


        </script>

</body>
</asp:Content>

