<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="Schedule.aspx.cs" Inherits="page_Schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
      <link rel="stylesheet" href="../css/jquery.schedule.css">
    <link rel="stylesheet" href="../css/jquery.schedule-demo.css">
 
    <body>
  <center>  <P1>ตารางปฏิบัติงานแพทย์</P1> </center>
      <div class="row">
            <div class="col">
                <div id="schedule" class="jqs-demo mb-3"></div>
            </div>
          <asp:Button ID="btnregister" runat="server" Text="ลงเวลาปฏิบัติงาน" BackColor="White" Height="45px" Width="203px" />
        </div>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="../js/jquery.schedule.js"></script>
        <script>

         //   $("#schedule").jqs();
            $("#schedule").jqs({
                mode: "read",
                data: [{
                    day: 0,
                    periods: [
                        ["20:00", "21:00"],
                        ["20:00", "22:00"], // Invalid period, not displayed
                        ["00:00", "02:00"]
                    ]
                }, {
                    day: 3,
                    periods: [
                        ["00:00", "08:30"],
                        ["09:00", "12:00"]
                    ]
                }]
            });
        </script>

</body>
</asp:Content>

