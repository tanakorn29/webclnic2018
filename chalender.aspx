<%@ Page Title="" Language="C#" MasterPageFile="~/page2.master" AutoEventWireup="true" CodeFile="chalender.aspx.cs" Inherits="chalender" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
      <link rel="stylesheet" href="../css/jquery.schedule.css">
    <link rel="stylesheet" href="../css/jquery.schedule-demo.css">
 
       <div id="schedule" class="jqs-demo mb-3"></div>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="../js/jquery.schedule.js"></script>
    <script>

        $("#schedule").jqs({
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
                 ["00:00", "08:30"]
                    ]
                }]
            });



    </script>
</asp:Content>

